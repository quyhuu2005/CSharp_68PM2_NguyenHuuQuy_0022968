using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class uc_QLLH : UserControl
    {
        private List<LopHoc> danhSachLopHoc = new List<LopHoc>();

        public uc_QLLH()
        {
            InitializeComponent();
            CauHinhBangLopHoc();
            btnTimLop.Click += btnTimLop_Click;
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

                BindDanhSach(danhSachLopHoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BindDanhSach(new List<LopHoc>());
            }
        }

        private void BindDanhSach(List<LopHoc> danhSach)
        {
            dataGridViewLopHoc.DataSource = null;
            dataGridViewLopHoc.DataSource = danhSach;
            lblClassPage.Text = $"Trang 1/1 | {danhSach.Count} ban ghi";
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
                            lh.MaLop.Contains(tuKhoa) ||
                            lh.TenLop.Contains(tuKhoa) ||
                            (lh.GiaoVien != null && lh.GiaoVien.Contains(tuKhoa)) ||
                            (lh.GhiChu != null && lh.GhiChu.Contains(tuKhoa)))
                        .OrderBy(lh => lh.MaLop)
                        .ToList();

                    BindDanhSach(ketQua);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tim kiem lop hoc: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
