using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class uc_QLSV : UserControl
    {
        private List<QuanLySinhVien> danhSachSinhVien = new List<QuanLySinhVien>();

        public uc_QLSV()
        {
            InitializeComponent();
        }

        private DataClasses1DataContext TaoKetNoi()
        {
            return new DataClasses1DataContext(Properties.Settings.Default.quanlysinhvienConnectionString);
        }

        private void uc_QLSV_Load(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
            XoaTrangForm();
        }

        private void LoadDanhSachSinhVien()
        {
            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    danhSachSinhVien = db.QuanLySinhViens
                        .OrderBy(sv => sv.MaSV)
                        .ToList();
                }

                BindDanhSach(danhSachSinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BindDanhSach(new List<QuanLySinhVien>());
            }
        }

        private void BindDanhSach(List<QuanLySinhVien> danhSach)
        {
            bindingSource2.DataMember = string.Empty;
            bindingSource2.DataSource = danhSach;
            dgv_qlsv.AutoGenerateColumns = false;
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

        private QuanLySinhVien LaySinhVienTuForm()
        {
            return new QuanLySinhVien
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
            txtMaSinhVien.Focus();
            dgv_qlsv.ClearSelection();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            QuanLySinhVien sinhVien = LaySinhVienTuForm();

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    bool daTonTai = db.QuanLySinhViens.Any(sv => sv.MaSV == sinhVien.MaSV);
                    if (daTonTai)
                    {
                        MessageBox.Show("Ma sinh vien da ton tai.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSinhVien.Focus();
                        return;
                    }

                    db.QuanLySinhViens.InsertOnSubmit(sinhVien);
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
                    List<QuanLySinhVien> ketQua = db.QuanLySinhViens
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

    }
}
