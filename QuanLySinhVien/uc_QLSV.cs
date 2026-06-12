using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class uc_QLSV : UserControl
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private string maSinhVienDangChon;

        public uc_QLSV()
        {
            InitializeComponent();
            CauHinhBangSinhVien();
            dgv_qlsv.CellClick += dgv_qlsv_CellClick;
            btnSuaSV.Click += btnSuaSV_Click;
        }

        private DataClasses1DataContext TaoKetNoi()
        {
            return new DataClasses1DataContext(Properties.Settings.Default.quanlysinhvienConnectionString);
        }

        private void uc_QLSV_Load(object sender, EventArgs e)
        {
            LoadDanhSachLop();
            LoadDanhSachSinhVien();
            XoaTrangForm();
        }

        private void CauHinhBangSinhVien()
        {
            dgv_qlsv.AutoGenerateColumns = false;
            dgv_qlsv.Columns.Clear();
            maSVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSV",
                HeaderText = "Ma SV",
                Name = "colMaSV"
            };
            hoTenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoTen",
                HeaderText = "Ho ten",
                Name = "colHoTen"
            };
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GioiTinh",
                HeaderText = "Gioi tinh",
                Name = "colGioiTinh"
            };
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngay sinh",
                Name = "colNgaySinh",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            };
            lopDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Lop",
                HeaderText = "Lop",
                Name = "colLop"
            };
            dgv_qlsv.Columns.AddRange(new DataGridViewColumn[]
            {
                maSVDataGridViewTextBoxColumn,
                hoTenDataGridViewTextBoxColumn,
                gioiTinhDataGridViewTextBoxColumn,
                ngaySinhDataGridViewTextBoxColumn,
                lopDataGridViewTextBoxColumn
            });
        }

        private void LoadDanhSachLop()
        {
            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    List<string> danhSachLop = db.LopHocs
                        .OrderBy(lh => lh.MaLop)
                        .Select(lh => lh.MaLop)
                        .ToList();

                    cmbLop.DataSource = danhSachLop;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu lop: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLop.DataSource = null;
            }
        }

        private void LoadDanhSachSinhVien()
        {
            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    danhSachSinhVien = db.SinhViens
                        .OrderBy(sv => sv.MaSV)
                        .ToList();
                }

                BindDanhSach(danhSachSinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BindDanhSach(new List<SinhVien>());
            }
        }

        private void BindDanhSach(List<SinhVien> danhSach)
        {
            bindingSource2.DataMember = string.Empty;
            bindingSource2.DataSource = danhSach;
            dgv_qlsv.DataSource = bindingSource2;
            lblStudentPage.Text = $"Trang 1/1 | {bindingSource2.Count} ban ghi";
        }

        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text))
            {
                MessageBox.Show("Vui long nhap ma sinh vien.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSinhVien.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui long nhap ho ten.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if
                (cmbGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui long chon gioi tinh.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGioiTinh.Focus();
                return false;
            }

            if (cmbLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui long chon lop.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLop.Focus();
                return false;
            }

            return true;
        }

        private SinhVien LaySinhVienTuForm()
        {
            return new SinhVien
            {
                MaSV = txtMaSinhVien.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = cmbGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value.Date,
                Lop = cmbLop.Text
            };
        }

        private void XoaTrangForm()
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtTimSV.Clear();

            if (cmbGioiTinh.Items.Count > 0)
            {
                cmbGioiTinh.SelectedIndex = 0;
            }

            if (cmbLop.Items.Count > 0)
            {
                cmbLop.SelectedIndex = 0;
            }

            dtpNgaySinh.Value = DateTime.Today;
            txtMaSinhVien.Enabled = true;
            btnSuaSV.Enabled = false;
            maSinhVienDangChon = null;
            txtMaSinhVien.Focus();
            dgv_qlsv.ClearSelection();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            SinhVien sinhVien = LaySinhVienTuForm();

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    bool daTonTai = db.SinhViens.Any(sv => sv.MaSV == sinhVien.MaSV);
                    if (daTonTai)
                    {
                        MessageBox.Show("Ma sinh vien da ton tai.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSinhVien.Focus();
                        return;
                    }

                    db.SinhViens.InsertOnSubmit(sinhVien);
                    db.SubmitChanges();
                }

                LoadDanhSachSinhVien();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi them sinh vien: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimSV.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachSinhVien();
                return;
            }

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    List<SinhVien> ketQua = db.SinhViens
                        .Where(sv =>
                            sv.MaSV.Contains(tuKhoa) ||
                            sv.HoTen.Contains(tuKhoa) ||
                            (sv.Lop != null && sv.Lop.Contains(tuKhoa)))
                        .OrderBy(sv => sv.MaSV)
                        .ToList();

                    BindDanhSach(ketQua);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tim kiem sinh vien: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSinhVienDangChon))
            {
                MessageBox.Show("Vui long chon sinh vien can sua.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    SinhVien sinhVien = db.SinhViens.SingleOrDefault(sv => sv.MaSV == maSinhVienDangChon);
                    if (sinhVien == null)
                    {
                        MessageBox.Show("Khong tim thay sinh vien can sua.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadDanhSachSinhVien();
                        XoaTrangForm();
                        return;
                    }

                    sinhVien.HoTen = txtHoTen.Text.Trim();
                    sinhVien.GioiTinh = cmbGioiTinh.Text;
                    sinhVien.NgaySinh = dtpNgaySinh.Value.Date;
                    sinhVien.Lop = cmbLop.Text;
                    db.SubmitChanges();
                }

                LoadDanhSachSinhVien();
                XoaTrangForm();
                MessageBox.Show("Sua sinh vien thanh cong.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi sua sinh vien: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiSinhVienLenForm(SinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                return;
            }

            maSinhVienDangChon = sinhVien.MaSV;
            txtMaSinhVien.Text = sinhVien.MaSV;
            txtHoTen.Text = sinhVien.HoTen;
            ChonGiaTriComboBox(cmbGioiTinh, sinhVien.GioiTinh);
            ChonGiaTriComboBox(cmbLop, sinhVien.Lop);
            dtpNgaySinh.Value = sinhVien.NgaySinh ?? DateTime.Today;
            txtMaSinhVien.Enabled = false;
            btnSuaSV.Enabled = true;
        }

        private void ChonGiaTriComboBox(ComboBox comboBox, string giaTri)
        {
            int viTri = comboBox.FindStringExact(giaTri ?? string.Empty);
            comboBox.SelectedIndex = viTri;
        }

        private void dgv_qlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            SinhVien sinhVien = dgv_qlsv.Rows[e.RowIndex].DataBoundItem as SinhVien;
            HienThiSinhVienLenForm(sinhVien);
        }

        private void dgv_qlsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
