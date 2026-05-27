using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        private readonly uc_QLSV ucSinhVien;
        private readonly uc_QLLH ucLopHoc;

        public FormMain()
        {
            InitializeComponent();
            ucSinhVien = new uc_QLSV();
            ucLopHoc = new uc_QLLH();
            ShowControl(ucSinhVien, btnQuanLySinhVien.Text);
            SetActiveButton(btnQuanLySinhVien);
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            ShowControl(ucSinhVien, "Quản lý sinh viên");
            SetActiveButton(btnQuanLySinhVien);
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            ShowControl(ucLopHoc, "Quản lý lớp học");
            SetActiveButton(btnQuanLyLopHoc);
        }

        private void ShowControl(UserControl control, string title)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
            lblTitle.Text = title;
        }

        private void SetActiveButton(Button activeButton)
        {
            Color activeColor = Color.FromArgb(41, 128, 185);
            Color inactiveColor = Color.FromArgb(149, 165, 166);

            btnQuanLySinhVien.BackColor = btnQuanLySinhVien == activeButton ? activeColor : inactiveColor;
            btnQuanLyLopHoc.BackColor = btnQuanLyLopHoc == activeButton ? activeColor : inactiveColor;
        }
    }
}
