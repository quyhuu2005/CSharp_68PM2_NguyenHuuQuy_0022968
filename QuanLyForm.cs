using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLyForm : Form
    {
        private int selectedRowIndex = -1;
        private int selectedRowIndexClass = -1;

        public QuanLyForm()
        {
            InitializeComponent();
            LoadStudentData();
            LoadClassData();
        }

        #region Student Management

        private void LoadStudentData()
        {
            dataGridViewSinhVien.Rows.Add("1", "Nguyễn Văn A", "Nam", "11/03/2006", "68PM1");
            dataGridViewSinhVien.Rows.Add("2", "Nguyễn Văn B", "Nam", "11/03/2006", "68PM2");
            dataGridViewSinhVien.Rows.Add("3", "Trần Văn C", "Nam", "21/03/2006", "68PM2");

            if (dataGridViewSinhVien.Rows.Count > 0)
            {
                dataGridViewSinhVien.Rows[0].Selected = true;
                PopulateStudentFields(0);
            }
            UpdateStudentPagination();
        }

        private void PopulateStudentFields(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewSinhVien.Rows.Count)
            {
                var row = dataGridViewSinhVien.Rows[rowIndex];
                txtMaSinhVien.Text = row.Cells[0].Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells[1].Value?.ToString() ?? "";
                cmbGioiTinh.SelectedItem = row.Cells[2].Value?.ToString() ?? "Nam";
                dtpNgaySinh.Value = DateTime.ParseExact(row.Cells[3].Value?.ToString() ?? DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
                cmbLop.SelectedItem = row.Cells[4].Value?.ToString() ?? "68PM1";
            }
        }

        private void UpdateStudentPagination()
        {
            lblStudentPage.Text = $"Trang 1/1 | {dataGridViewSinhVien.Rows.Count} bản ghi";
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                if (StudentIDExists(txtMaSinhVien.Text))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dataGridViewSinhVien.Rows.Add(
                    txtMaSinhVien.Text,
                    txtHoTen.Text,
                    cmbGioiTinh.SelectedItem.ToString(),
                    dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                    cmbLop.SelectedItem.ToString()
                );
                ClearStudentFields();
                MessageBox.Show("Thêm sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStudentPagination();
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateStudentInput())
            {
                string currentID = dataGridViewSinhVien.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string newID = txtMaSinhVien.Text;

                if (newID != currentID && StudentIDExists(newID))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dataGridViewSinhVien.Rows[selectedRowIndex];
                row.Cells[0].Value = newID;
                row.Cells[1].Value = txtHoTen.Text;
                row.Cells[2].Value = cmbGioiTinh.SelectedItem.ToString();
                row.Cells[3].Value = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                row.Cells[4].Value = cmbLop.SelectedItem.ToString();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewSinhVien.Rows.RemoveAt(selectedRowIndex);
                ClearStudentFields();
                selectedRowIndex = -1;
                MessageBox.Show("Xóa sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStudentPagination();
            }
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            ClearStudentFields();
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            string search = txtTimSV.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewSinhVien.Rows)
            {
                if ((row.Cells[1].Value?.ToString() ?? "").ToLower().Contains(search) ||
                    (row.Cells[0].Value?.ToString() ?? "").ToLower().Contains(search))
                {
                    dataGridViewSinhVien.ClearSelection();
                    row.Selected = true;
                    selectedRowIndex = row.Index;
                    dataGridViewSinhVien.FirstDisplayedScrollingRowIndex = row.Index;
                    PopulateStudentFields(row.Index);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                PopulateStudentFields(e.RowIndex);
            }
        }

        private bool StudentIDExists(string id)
        {
            foreach (DataGridViewRow row in dataGridViewSinhVien.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id)
                    return true;
            }
            return false;
        }

        private bool ValidateStudentInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearStudentFields()
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            cmbGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            cmbLop.SelectedIndex = 0;
            txtTimSV.Clear();
        }

        #endregion

        #region Class Management

        private void LoadClassData()
        {
            // Start with an empty class list so the user can add classes manually.
            dataGridViewLopHoc.Rows.Clear();
            UpdateClassPagination();
        }

        private void PopulateClassFields(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewLopHoc.Rows.Count)
            {
                var row = dataGridViewLopHoc.Rows[rowIndex];
                txtMaLop.Text = row.Cells[0].Value?.ToString() ?? "";
                txtTenLop.Text = row.Cells[1].Value?.ToString() ?? "";
                txtGiaoVien.Text = row.Cells[2].Value?.ToString() ?? "";
                txtSoLuong.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void UpdateClassPagination()
        {
            lblClassPage.Text = $"Trang 1/1 | {dataGridViewLopHoc.Rows.Count} bản ghi";
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (ValidateClassInput())
            {
                if (ClassIDExists(txtMaLop.Text))
                {
                    MessageBox.Show("Mã lớp này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dataGridViewLopHoc.Rows.Add(
                    txtMaLop.Text,
                    txtTenLop.Text,
                    txtGiaoVien.Text,
                    txtSoLuong.Text
                );
                ClearClassFields();
                MessageBox.Show("Thêm lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateClassPagination();
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (selectedRowIndexClass < 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateClassInput())
            {
                string currentID = dataGridViewLopHoc.Rows[selectedRowIndexClass].Cells[0].Value.ToString();
                string newID = txtMaLop.Text;

                if (newID != currentID && ClassIDExists(newID))
                {
                    MessageBox.Show("Mã lớp này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dataGridViewLopHoc.Rows[selectedRowIndexClass];
                row.Cells[0].Value = newID;
                row.Cells[1].Value = txtTenLop.Text;
                row.Cells[2].Value = txtGiaoVien.Text;
                row.Cells[3].Value = txtSoLuong.Text;
                MessageBox.Show("Cập nhật lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (selectedRowIndexClass < 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewLopHoc.Rows.RemoveAt(selectedRowIndexClass);
                ClearClassFields();
                selectedRowIndexClass = -1;
                MessageBox.Show("Xóa lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateClassPagination();
            }
        }

        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            ClearClassFields();
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            string search = txtTimLop.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewLopHoc.Rows)
            {
                if ((row.Cells[1].Value?.ToString() ?? "").ToLower().Contains(search) ||
                    (row.Cells[0].Value?.ToString() ?? "").ToLower().Contains(search))
                {
                    dataGridViewLopHoc.ClearSelection();
                    row.Selected = true;
                    selectedRowIndexClass = row.Index;
                    dataGridViewLopHoc.FirstDisplayedScrollingRowIndex = row.Index;
                    PopulateClassFields(row.Index);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndexClass = e.RowIndex;
                PopulateClassFields(e.RowIndex);
            }
        }

        private bool ClassIDExists(string id)
        {
            foreach (DataGridViewRow row in dataGridViewLopHoc.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id)
                    return true;
            }
            return false;
        }

        private bool ValidateClassInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearClassFields()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGiaoVien.Clear();
            txtSoLuong.Clear();
            txtTimLop.Clear();
        }

        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
    }
}
