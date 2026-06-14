using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class uc_QLLH : UserControl
    {
        private const int SoDongMoiTrang = 10;
        private List<LopHoc> danhSachLopHoc = new List<LopHoc>();
        private List<LopHoc> danhSachDangHienThi = new List<LopHoc>();
        private int trangHienTai = 1;
        private string maLopDangChon;

        public uc_QLLH()
        {
            InitializeComponent();
            CauHinhBangLopHoc();
            dataGridViewLopHoc.CellClick += dataGridViewLopHoc_CellClick;
            btnThemLop.Click += btnThemLop_Click;
            btnSuaLop.Click += btnSuaLop_Click;
            btnXoaLop.Click += btnXoaLop_Click;
            btnLamMoiLop.Click += btnLamMoiLop_Click;
            btnXemSinhVienLop.Click += btnXemSinhVienLop_Click;
            btnTimLop.Click += btnTimLop_Click;
            btnFirstPageLop.Click += btnFirstPageLop_Click;
            btnPreviousPageLop.Click += btnPreviousPageLop_Click;
            btnNextPageLop.Click += btnNextPageLop_Click;
            btnLastPageLop.Click += btnLastPageLop_Click;
            txtTimLop.KeyDown += txtTimLop_KeyDown;
        }

        private DataClasses1DataContext TaoKetNoi()
        {
            return new DataClasses1DataContext(Properties.Settings.Default.quanlysinhvienConnectionString);
        }

        private void CauHinhBangLopHoc()
        {
            dataGridViewLopHoc.AutoGenerateColumns = false;
            dataGridViewLopHoc.Columns.Clear();
            dataGridViewLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaID",
                HeaderText = "Ma ID",
                Name = "colMaID"
            });
            dataGridViewLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaLop",
                HeaderText = "Ma lop",
                Name = "colMaLop"
            });
            dataGridViewLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenLop",
                HeaderText = "Ten lop",
                Name = "colTenLop"
            });
            dataGridViewLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GiaoVien",
                HeaderText = "Giao vien",
                Name = "colGiaoVien"
            });
            dataGridViewLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GhiChu",
                HeaderText = "Ghi chu",
                Name = "colGhiChu"
            });
        }

        private void uc_QLLH_Load(object sender, EventArgs e)
        {
            LoadDanhSachLopHoc();
            XoaTrangForm();
        }

        private void LoadDanhSachLopHoc()
        {
            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    danhSachLopHoc = db.LopHocs
                        .OrderBy(lh => lh.MaLop)
                        .ToList();
                }

                BindDanhSach(danhSachLopHoc, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BindDanhSach(new List<LopHoc>(), true);
            }
        }

        private void BindDanhSach(List<LopHoc> danhSach, bool veTrangDau)
        {
            danhSachDangHienThi = danhSach ?? new List<LopHoc>();
            if (veTrangDau)
            {
                trangHienTai = 1;
            }

            CapNhatTrangLopHoc();
        }

        private int LayTongTrangLopHoc()
        {
            return Math.Max(1, (int)Math.Ceiling(danhSachDangHienThi.Count / (double)SoDongMoiTrang));
        }

        private void CapNhatTrangLopHoc()
        {
            int tongTrang = LayTongTrangLopHoc();
            if (trangHienTai < 1)
            {
                trangHienTai = 1;
            }

            if (trangHienTai > tongTrang)
            {
                trangHienTai = tongTrang;
            }

            List<LopHoc> duLieuTrang = danhSachDangHienThi
                .Skip((trangHienTai - 1) * SoDongMoiTrang)
                .Take(SoDongMoiTrang)
                .ToList();

            bindingSourceLopHoc.DataMember = string.Empty;
            bindingSourceLopHoc.DataSource = duLieuTrang;
            dataGridViewLopHoc.DataSource = bindingSourceLopHoc;
            lblClassPage.Text = $"Trang {trangHienTai}/{tongTrang} | {danhSachDangHienThi.Count} ban ghi";

            bool coTrangTruoc = trangHienTai > 1;
            bool coTrangSau = trangHienTai < tongTrang;
            btnFirstPageLop.Enabled = coTrangTruoc;
            btnPreviousPageLop.Enabled = coTrangTruoc;
            btnNextPageLop.Enabled = coTrangSau;
            btnLastPageLop.Enabled = coTrangSau;
            XoaThongTinLopDangChon();
        }

        private void ChuyenTrangLopHoc(int trangMoi)
        {
            trangHienTai = trangMoi;
            CapNhatTrangLopHoc();
        }

        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui long nhap ma lop.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui long nhap ten lop.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return false;
            }

            return true;
        }

        private LopHoc LayLopHocTuForm()
        {
            return new LopHoc
            {
                MaLop = txtMaLop.Text.Trim(),
                TenLop = txtTenLop.Text.Trim(),
                GiaoVien = LayChuoiHoacNull(txtGiaoVien.Text),
                GhiChu = LayChuoiHoacNull(txtGhiChu.Text)
            };
        }

        private string LayChuoiHoacNull(string giaTri)
        {
            return string.IsNullOrWhiteSpace(giaTri) ? null : giaTri.Trim();
        }

        private void XoaTrangForm()
        {
            XoaThongTinLopDangChon();
            txtTimLop.Clear();
            txtMaLop.Focus();
        }

        private void XoaThongTinLopDangChon()
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGiaoVien.Clear();
            txtGhiChu.Clear();
            txtMaLop.Enabled = true;
            btnSuaLop.Enabled = false;
            btnXoaLop.Enabled = false;
            btnXemSinhVienLop.Enabled = false;
            maLopDangChon = null;
            dataGridViewLopHoc.ClearSelection();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            LopHoc lopHoc = LayLopHocTuForm();

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    bool daTonTai = db.LopHocs.Any(lh => lh.MaLop == lopHoc.MaLop);
                    if (daTonTai)
                    {
                        MessageBox.Show("Ma lop da ton tai.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLop.Focus();
                        return;
                    }

                    db.LopHocs.InsertOnSubmit(lopHoc);
                    db.SubmitChanges();
                }

                LoadDanhSachLopHoc();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi them lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimLop.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachLopHoc();
                return;
            }

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    List<LopHoc> ketQua = db.LopHocs
                        .Where(lh =>
                            (lh.MaLop != null && lh.MaLop.Contains(tuKhoa)) ||
                            (lh.TenLop != null && lh.TenLop.Contains(tuKhoa)) ||
                            (lh.GiaoVien != null && lh.GiaoVien.Contains(tuKhoa)) ||
                            (lh.GhiChu != null && lh.GhiChu.Contains(tuKhoa)))
                        .OrderBy(lh => lh.MaLop)
                        .ToList();

                    BindDanhSach(ketQua, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tim kiem lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            txtTimLop.Clear();
            LoadDanhSachLopHoc();
            XoaTrangForm();
        }

        private void btnFirstPageLop_Click(object sender, EventArgs e)
        {
            ChuyenTrangLopHoc(1);
        }

        private void btnPreviousPageLop_Click(object sender, EventArgs e)
        {
            ChuyenTrangLopHoc(trangHienTai - 1);
        }

        private void btnNextPageLop_Click(object sender, EventArgs e)
        {
            ChuyenTrangLopHoc(trangHienTai + 1);
        }

        private void btnLastPageLop_Click(object sender, EventArgs e)
        {
            ChuyenTrangLopHoc(LayTongTrangLopHoc());
        }

        private void txtTimLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTimLop_Click(sender, EventArgs.Empty);
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maLopDangChon))
            {
                MessageBox.Show("Vui long chon lop hoc can sua.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    LopHoc lopHoc = db.LopHocs.SingleOrDefault(lh => lh.MaLop == maLopDangChon);
                    if (lopHoc == null)
                    {
                        MessageBox.Show("Khong tim thay lop hoc can sua.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadDanhSachLopHoc();
                        XoaTrangForm();
                        return;
                    }

                    lopHoc.TenLop = txtTenLop.Text.Trim();
                    lopHoc.GiaoVien = LayChuoiHoacNull(txtGiaoVien.Text);
                    lopHoc.GhiChu = LayChuoiHoacNull(txtGhiChu.Text);
                    db.SubmitChanges();
                }

                LoadDanhSachLopHoc();
                XoaTrangForm();
                MessageBox.Show("Sua lop hoc thanh cong.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi sua lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maLopDangChon))
            {
                MessageBox.Show("Vui long chon lop hoc can xoa.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                $"Ban co chac muon xoa lop {txtTenLop.Text.Trim()} ({maLopDangChon})?",
                "Xac nhan xoa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    bool coSinhVien = db.SinhViens.Any(sv => sv.Lop == maLopDangChon);
                    if (coSinhVien)
                    {
                        MessageBox.Show("Khong the xoa lop hoc dang co sinh vien.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LopHoc lopHoc = db.LopHocs.SingleOrDefault(lh => lh.MaLop == maLopDangChon);
                    if (lopHoc == null)
                    {
                        MessageBox.Show("Khong tim thay lop hoc can xoa.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadDanhSachLopHoc();
                        XoaTrangForm();
                        return;
                    }

                    db.LopHocs.DeleteOnSubmit(lopHoc);
                    db.SubmitChanges();
                }

                LoadDanhSachLopHoc();
                XoaTrangForm();
                MessageBox.Show("Xoa lop hoc thanh cong.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi xoa lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiLopHocLenForm(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return;
            }

            maLopDangChon = lopHoc.MaLop;
            txtMaID.Text = lopHoc.MaID.ToString();
            txtMaLop.Text = lopHoc.MaLop;
            txtTenLop.Text = lopHoc.TenLop;
            txtGiaoVien.Text = lopHoc.GiaoVien;
            txtGhiChu.Text = lopHoc.GhiChu;
            txtMaLop.Enabled = false;
            btnSuaLop.Enabled = true;
            btnXoaLop.Enabled = true;
            btnXemSinhVienLop.Enabled = true;
        }

        private void btnXemSinhVienLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maLopDangChon))
            {
                MessageBox.Show("Vui long chon lop hoc can xem danh sach sinh vien.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<SinhVien> danhSachSinhVien;
                using (DataClasses1DataContext db = TaoKetNoi())
                {
                    danhSachSinhVien = db.SinhViens
                        .Where(sv => sv.Lop == maLopDangChon)
                        .OrderBy(sv => sv.MaSV)
                        .ToList();
                }

                HienThiDanhSachSinhVien(danhSachSinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai danh sach sinh vien: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
        {
            using (Form formDanhSach = new Form())
            {
                Label lblTieuDe = new Label
                {
                    Dock = DockStyle.Top,
                    Height = 36,
                    Padding = new Padding(10, 0, 0, 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $"Lop {maLopDangChon} - {danhSachSinhVien.Count} sinh vien"
                };

                DataGridView dgvSinhVien = new DataGridView
                {
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AutoGenerateColumns = false,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Dock = DockStyle.Fill,
                    MultiSelect = false,
                    ReadOnly = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };

                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaSV",
                    HeaderText = "Ma SV",
                    Name = "colMaSV"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "HoTen",
                    HeaderText = "Ho ten",
                    Name = "colHoTen"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GioiTinh",
                    HeaderText = "Gioi tinh",
                    Name = "colGioiTinh"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NgaySinh",
                    HeaderText = "Ngay sinh",
                    Name = "colNgaySinh",
                    DefaultCellStyle = { Format = "dd/MM/yyyy" }
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Lop",
                    HeaderText = "Lop",
                    Name = "colLop"
                });
                dgvSinhVien.DataSource = danhSachSinhVien;

                formDanhSach.Text = "Danh sach sinh vien";
                formDanhSach.StartPosition = FormStartPosition.CenterParent;
                formDanhSach.Size = new Size(760, 420);
                formDanhSach.MinimizeBox = false;
                formDanhSach.Controls.Add(dgvSinhVien);
                formDanhSach.Controls.Add(lblTieuDe);
                formDanhSach.ShowDialog(this);
            }
        }

        private void dataGridViewLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            LopHoc lopHoc = dataGridViewLopHoc.Rows[e.RowIndex].DataBoundItem as LopHoc;
            HienThiLopHocLenForm(lopHoc);
        }
    }
}
