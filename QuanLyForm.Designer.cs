namespace QuanLySinhVien
{
    partial class QuanLyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSinhVien;
        private System.Windows.Forms.TabPage tabLopHoc;
        private System.Windows.Forms.TabPage tabDangXuat;

        // Student Tab Controls
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnLamMoiSV;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Label lblTimSV;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.Button btnTimSV;
        private System.Windows.Forms.Label lblStudentPage;

        // Class Tab Controls
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblGiaoVien;
        private System.Windows.Forms.TextBox txtGiaoVien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnLamMoiLop;
        private System.Windows.Forms.DataGridView dataGridViewLopHoc;
        private System.Windows.Forms.Label lblTimLop;
        private System.Windows.Forms.TextBox txtTimLop;
        private System.Windows.Forms.Button btnTimLop;
        private System.Windows.Forms.Label lblClassPage;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.tabLopHoc = new System.Windows.Forms.TabPage();
            this.tabDangXuat = new System.Windows.Forms.TabPage();

            // Initialize Student Tab
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLop = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnLamMoiSV = new System.Windows.Forms.Button();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.lblTimSV = new System.Windows.Forms.Label();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.btnTimSV = new System.Windows.Forms.Button();
            this.lblStudentPage = new System.Windows.Forms.Label();

            // Initialize Class Tab
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblGiaoVien = new System.Windows.Forms.Label();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnLamMoiLop = new System.Windows.Forms.Button();
            this.dataGridViewLopHoc = new System.Windows.Forms.DataGridView();
            this.lblTimLop = new System.Windows.Forms.Label();
            this.txtTimLop = new System.Windows.Forms.TextBox();
            this.btnTimLop = new System.Windows.Forms.Button();
            this.lblClassPage = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopHoc)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabSinhVien);
            this.tabControl.Controls.Add(this.tabLopHoc);
            this.tabControl.Controls.Add(this.tabDangXuat);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 700);
            this.tabControl.TabIndex = 0;

            // ===== STUDENT TAB =====
            this.tabSinhVien.Controls.Add(this.lblMaSinhVien);
            this.tabSinhVien.Controls.Add(this.txtMaSinhVien);
            this.tabSinhVien.Controls.Add(this.lblHoTen);
            this.tabSinhVien.Controls.Add(this.txtHoTen);
            this.tabSinhVien.Controls.Add(this.lblGioiTinh);
            this.tabSinhVien.Controls.Add(this.cmbGioiTinh);
            this.tabSinhVien.Controls.Add(this.lblNgaySinh);
            this.tabSinhVien.Controls.Add(this.dtpNgaySinh);
            this.tabSinhVien.Controls.Add(this.lblLop);
            this.tabSinhVien.Controls.Add(this.cmbLop);
            this.tabSinhVien.Controls.Add(this.btnThemSV);
            this.tabSinhVien.Controls.Add(this.btnSuaSV);
            this.tabSinhVien.Controls.Add(this.btnXoaSV);
            this.tabSinhVien.Controls.Add(this.btnLamMoiSV);
            this.tabSinhVien.Controls.Add(this.lblTimSV);
            this.tabSinhVien.Controls.Add(this.txtTimSV);
            this.tabSinhVien.Controls.Add(this.btnTimSV);
            this.tabSinhVien.Controls.Add(this.dataGridViewSinhVien);
            this.tabSinhVien.Controls.Add(this.lblStudentPage);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 25);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinhVien.Size = new System.Drawing.Size(1192, 671);
            this.tabSinhVien.TabIndex = 0;
            this.tabSinhVien.Text = "Quản lý Sinh Viên";
            this.tabSinhVien.UseVisualStyleBackColor = true;

            // Student Left Panel Controls
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(20, 20);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(80, 16);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã sinh viên:";

            this.txtMaSinhVien.Location = new System.Drawing.Point(20, 40);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(320, 22);
            this.txtMaSinhVien.TabIndex = 1;

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";

            this.txtHoTen.Location = new System.Drawing.Point(20, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 22);
            this.txtHoTen.TabIndex = 3;

            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 120);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";

            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cmbGioiTinh.Location = new System.Drawing.Point(20, 140);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(320, 24);
            this.cmbGioiTinh.TabIndex = 5;
            this.cmbGioiTinh.SelectedIndex = 0;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 170);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(71, 16);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";

            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 190);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(320, 22);
            this.dtpNgaySinh.TabIndex = 7;

            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(20, 220);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(34, 16);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp:";

            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Items.AddRange(new object[] { "68PM1", "68PM2" });
            this.cmbLop.Location = new System.Drawing.Point(20, 240);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(320, 24);
            this.cmbLop.TabIndex = 9;
            this.cmbLop.SelectedIndex = 0;

            this.btnThemSV.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThemSV.ForeColor = System.Drawing.Color.White;
            this.btnThemSV.Location = new System.Drawing.Point(20, 280);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(150, 40);
            this.btnThemSV.TabIndex = 10;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);

            this.btnSuaSV.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSuaSV.ForeColor = System.Drawing.Color.White;
            this.btnSuaSV.Location = new System.Drawing.Point(190, 280);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(150, 40);
            this.btnSuaSV.TabIndex = 11;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = false;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);

            this.btnXoaSV.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Location = new System.Drawing.Point(20, 330);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(150, 40);
            this.btnXoaSV.TabIndex = 12;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = false;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);

            this.btnLamMoiSV.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLamMoiSV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSV.Location = new System.Drawing.Point(190, 330);
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoiSV.TabIndex = 13;
            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.UseVisualStyleBackColor = false;
            this.btnLamMoiSV.Click += new System.EventHandler(this.btnLamMoiSV_Click);

            // Student Right Panel Controls
            this.lblTimSV.AutoSize = true;
            this.lblTimSV.Location = new System.Drawing.Point(370, 20);
            this.lblTimSV.Name = "lblTimSV";
            this.lblTimSV.Size = new System.Drawing.Size(200, 16);
            this.lblTimSV.TabIndex = 14;
            this.lblTimSV.Text = "Tìm kiếm (Tên / Mã SV):";

            this.txtTimSV.Location = new System.Drawing.Point(370, 40);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(500, 22);
            this.txtTimSV.TabIndex = 15;

            this.btnTimSV.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnTimSV.ForeColor = System.Drawing.Color.White;
            this.btnTimSV.Location = new System.Drawing.Point(880, 40);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(100, 22);
            this.btnTimSV.TabIndex = 16;
            this.btnTimSV.Text = "Tìm";
            this.btnTimSV.UseVisualStyleBackColor = false;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);

            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(370, 70);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(800, 550);
            this.dataGridViewSinhVien.TabIndex = 17;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);

            this.dataGridViewSinhVien.Columns.Add("MaSV", "Mã SV");
            this.dataGridViewSinhVien.Columns.Add("HoTen", "Họ và Tên");
            this.dataGridViewSinhVien.Columns.Add("GioiTinh", "Giới Tính");
            this.dataGridViewSinhVien.Columns.Add("NgaySinh", "Ngày Sinh");
            this.dataGridViewSinhVien.Columns.Add("Lop", "Lớp");

            this.lblStudentPage.AutoSize = true;
            this.lblStudentPage.Location = new System.Drawing.Point(370, 630);
            this.lblStudentPage.Name = "lblStudentPage";
            this.lblStudentPage.Size = new System.Drawing.Size(120, 16);
            this.lblStudentPage.TabIndex = 18;
            this.lblStudentPage.Text = "Trang 1/1 | 0 bản ghi";

            // ===== CLASS TAB =====
            this.tabLopHoc.Controls.Add(this.lblMaLop);
            this.tabLopHoc.Controls.Add(this.txtMaLop);
            this.tabLopHoc.Controls.Add(this.lblTenLop);
            this.tabLopHoc.Controls.Add(this.txtTenLop);
            this.tabLopHoc.Controls.Add(this.lblGiaoVien);
            this.tabLopHoc.Controls.Add(this.txtGiaoVien);
            this.tabLopHoc.Controls.Add(this.lblSoLuong);
            this.tabLopHoc.Controls.Add(this.txtSoLuong);
            this.tabLopHoc.Controls.Add(this.btnThemLop);
            this.tabLopHoc.Controls.Add(this.btnSuaLop);
            this.tabLopHoc.Controls.Add(this.btnXoaLop);
            this.tabLopHoc.Controls.Add(this.btnLamMoiLop);
            this.tabLopHoc.Controls.Add(this.lblTimLop);
            this.tabLopHoc.Controls.Add(this.txtTimLop);
            this.tabLopHoc.Controls.Add(this.btnTimLop);
            this.tabLopHoc.Controls.Add(this.dataGridViewLopHoc);
            this.tabLopHoc.Controls.Add(this.lblClassPage);
            this.tabLopHoc.Location = new System.Drawing.Point(4, 25);
            this.tabLopHoc.Name = "tabLopHoc";
            this.tabLopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabLopHoc.Size = new System.Drawing.Size(1192, 671);
            this.tabLopHoc.TabIndex = 1;
            this.tabLopHoc.Text = "Quản lý Lớp Học";
            this.tabLopHoc.UseVisualStyleBackColor = true;

            // Class Left Panel Controls
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(20, 20);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(70, 16);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp:";

            this.txtMaLop.Location = new System.Drawing.Point(20, 40);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(320, 22);
            this.txtMaLop.TabIndex = 1;

            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(20, 70);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(72, 16);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên lớp:";

            this.txtTenLop.Location = new System.Drawing.Point(20, 90);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(320, 22);
            this.txtTenLop.TabIndex = 3;

            this.lblGiaoVien.AutoSize = true;
            this.lblGiaoVien.Location = new System.Drawing.Point(20, 120);
            this.lblGiaoVien.Name = "lblGiaoVien";
            this.lblGiaoVien.Size = new System.Drawing.Size(61, 16);
            this.lblGiaoVien.TabIndex = 4;
            this.lblGiaoVien.Text = "Giáo viên:";

            this.txtGiaoVien.Location = new System.Drawing.Point(20, 140);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.Size = new System.Drawing.Size(320, 22);
            this.txtGiaoVien.TabIndex = 5;

            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 170);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(118, 16);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng sinh viên:";

            this.txtSoLuong.Location = new System.Drawing.Point(20, 190);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(320, 22);
            this.txtSoLuong.TabIndex = 7;

            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(20, 240);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(150, 40);
            this.btnThemLop.TabIndex = 8;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);

            this.btnSuaLop.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(190, 240);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(150, 40);
            this.btnSuaLop.TabIndex = 9;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = false;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);

            this.btnXoaLop.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(20, 290);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(150, 40);
            this.btnXoaLop.TabIndex = 10;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);

            this.btnLamMoiLop.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLamMoiLop.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiLop.Location = new System.Drawing.Point(190, 290);
            this.btnLamMoiLop.Name = "btnLamMoiLop";
            this.btnLamMoiLop.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoiLop.TabIndex = 11;
            this.btnLamMoiLop.Text = "Làm mới";
            this.btnLamMoiLop.UseVisualStyleBackColor = false;
            this.btnLamMoiLop.Click += new System.EventHandler(this.btnLamMoiLop_Click);

            // Class Right Panel Controls
            this.lblTimLop.AutoSize = true;
            this.lblTimLop.Location = new System.Drawing.Point(370, 20);
            this.lblTimLop.Name = "lblTimLop";
            this.lblTimLop.Size = new System.Drawing.Size(200, 16);
            this.lblTimLop.TabIndex = 12;
            this.lblTimLop.Text = "Tìm kiếm (Tên / Mã Lớp):";

            this.txtTimLop.Location = new System.Drawing.Point(370, 40);
            this.txtTimLop.Name = "txtTimLop";
            this.txtTimLop.Size = new System.Drawing.Size(500, 22);
            this.txtTimLop.TabIndex = 13;

            this.btnTimLop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnTimLop.ForeColor = System.Drawing.Color.White;
            this.btnTimLop.Location = new System.Drawing.Point(880, 40);
            this.btnTimLop.Name = "btnTimLop";
            this.btnTimLop.Size = new System.Drawing.Size(100, 22);
            this.btnTimLop.TabIndex = 14;
            this.btnTimLop.Text = "Tìm";
            this.btnTimLop.UseVisualStyleBackColor = false;
            this.btnTimLop.Click += new System.EventHandler(this.btnTimLop_Click);

            this.dataGridViewLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLopHoc.Location = new System.Drawing.Point(370, 70);
            this.dataGridViewLopHoc.Name = "dataGridViewLopHoc";
            this.dataGridViewLopHoc.Size = new System.Drawing.Size(800, 550);
            this.dataGridViewLopHoc.TabIndex = 15;
            this.dataGridViewLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLopHoc_CellClick);

            this.dataGridViewLopHoc.Columns.Add("MaLop", "Mã Lớp");
            this.dataGridViewLopHoc.Columns.Add("TenLop", "Tên Lớp");
            this.dataGridViewLopHoc.Columns.Add("GiaoVien", "Giáo Viên");
            this.dataGridViewLopHoc.Columns.Add("SoLuong", "Số Lượng SV");

            this.lblClassPage.AutoSize = true;
            this.lblClassPage.Location = new System.Drawing.Point(370, 630);
            this.lblClassPage.Name = "lblClassPage";
            this.lblClassPage.Size = new System.Drawing.Size(120, 16);
            this.lblClassPage.TabIndex = 16;
            this.lblClassPage.Text = "Trang 1/1 | 0 bản ghi";

            // ===== LOGOUT TAB =====
            this.tabDangXuat.Location = new System.Drawing.Point(4, 25);
            this.tabDangXuat.Name = "tabDangXuat";
            this.tabDangXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangXuat.Size = new System.Drawing.Size(1192, 671);
            this.tabDangXuat.TabIndex = 2;
            this.tabDangXuat.Text = "Đăng xuất";
            this.tabDangXuat.UseVisualStyleBackColor = true;

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(450, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 60);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.tabDangXuat.Controls.Add(this.btnLogout);

            // QuanLyForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl);
            this.Name = "QuanLyForm";
            this.Text = "Quản Lý Sinh Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopHoc)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
