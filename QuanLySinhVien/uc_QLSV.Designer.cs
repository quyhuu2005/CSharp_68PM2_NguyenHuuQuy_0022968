namespace QuanLySinhVien
{
    partial class uc_QLSV
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

        #region Component Designer generated code

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
        private System.Windows.Forms.Label lblTimSV;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.Button btnTimSV;
        private System.Windows.Forms.DataGridView dgv_qlsv;
        private System.Windows.Forms.Label lblStudentPage;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.lblTimSV = new System.Windows.Forms.Label();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.btnTimSV = new System.Windows.Forms.Button();
            this.dgv_qlsv = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblStudentPage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFirstPageSV = new System.Windows.Forms.Button();
            this.btnPreviousPageSV = new System.Windows.Forms.Button();
            this.btnNextPageSV = new System.Windows.Forms.Button();
            this.btnLastPageSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(9, 30);
            this.lblMaSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(84, 16);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã sinh viên:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(9, 45);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(241, 22);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 83);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(9, 103);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(241, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 142);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(9, 157);
            this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(241, 24);
            this.cmbGioiTinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(6, 196);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(9, 211);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(241, 22);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(6, 250);
            this.lblLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp:";
            // 
            // cmbLop
            // 
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Items.AddRange(new object[] {
            "68PM1",
            "68PM2"});
            this.cmbLop.Location = new System.Drawing.Point(9, 265);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(241, 24);
            this.cmbLop.TabIndex = 9;
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemSV.ForeColor = System.Drawing.Color.White;
            this.btnThemSV.Location = new System.Drawing.Point(6, 383);
            this.btnThemSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(124, 45);
            this.btnThemSV.TabIndex = 10;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSuaSV.Enabled = false;
            this.btnSuaSV.ForeColor = System.Drawing.Color.White;
            this.btnSuaSV.Location = new System.Drawing.Point(144, 383);
            this.btnSuaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(134, 45);
            this.btnSuaSV.TabIndex = 11;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = false;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaSV.Enabled = false;
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Location = new System.Drawing.Point(6, 447);
            this.btnXoaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(124, 40);
            this.btnXoaSV.TabIndex = 12;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = false;
            // 
            // btnLamMoiSV
            // 
            this.btnLamMoiSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLamMoiSV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSV.Location = new System.Drawing.Point(144, 447);
            this.btnLamMoiSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.Size = new System.Drawing.Size(134, 40);
            this.btnLamMoiSV.TabIndex = 13;
            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.UseVisualStyleBackColor = false;
            // 
            // lblTimSV
            // 
            this.lblTimSV.AutoSize = true;
            this.lblTimSV.Location = new System.Drawing.Point(306, 57);
            this.lblTimSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimSV.Name = "lblTimSV";
            this.lblTimSV.Size = new System.Drawing.Size(123, 13);
            this.lblTimSV.TabIndex = 14;
            this.lblTimSV.Text = "Tìm kiếm (Tên / Mã SV):";
            // 
            // txtTimSV
            // 
            this.txtTimSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSV.Location = new System.Drawing.Point(309, 72);
            this.txtTimSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(502, 20);
            this.txtTimSV.TabIndex = 15;
            // 
            // btnTimSV
            // 
            this.btnTimSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimSV.ForeColor = System.Drawing.Color.White;
            this.btnTimSV.Location = new System.Drawing.Point(816, 68);
            this.btnTimSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(105, 31);
            this.btnTimSV.TabIndex = 16;
            this.btnTimSV.Text = "Tìm";
            this.btnTimSV.UseVisualStyleBackColor = false;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // dgv_qlsv
            // 
            this.dgv_qlsv.AllowUserToAddRows = false;
            this.dgv_qlsv.AllowUserToDeleteRows = false;
            this.dgv_qlsv.AutoGenerateColumns = false;
            this.dgv_qlsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlsv.DataSource = this.bindingSource2;
            this.dgv_qlsv.Location = new System.Drawing.Point(309, 121);
            this.dgv_qlsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_qlsv.MultiSelect = false;
            this.dgv_qlsv.Name = "dgv_qlsv";
            this.dgv_qlsv.ReadOnly = true;
            this.dgv_qlsv.RowHeadersWidth = 51;
            this.dgv_qlsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qlsv.Size = new System.Drawing.Size(616, 328);
            this.dgv_qlsv.TabIndex = 17;
            this.dgv_qlsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlsv_CellContentClick);
            // 
            // lblStudentPage
            // 
            this.lblStudentPage.AutoSize = true;
            this.lblStudentPage.Location = new System.Drawing.Point(509, 467);
            this.lblStudentPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentPage.Name = "lblStudentPage";
            this.lblStudentPage.Size = new System.Drawing.Size(107, 13);
            this.lblStudentPage.TabIndex = 18;
            this.lblStudentPage.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaSinhVien);
            this.groupBox1.Controls.Add(this.txtMaSinhVien);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 313);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnFirstPageSV
            // 
            this.btnFirstPageSV.Enabled = false;
            this.btnFirstPageSV.Location = new System.Drawing.Point(309, 462);
            this.btnFirstPageSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirstPageSV.Name = "btnFirstPageSV";
            this.btnFirstPageSV.Size = new System.Drawing.Size(64, 25);
            this.btnFirstPageSV.TabIndex = 20;
            this.btnFirstPageSV.Text = "<<";
            this.btnFirstPageSV.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPageSV
            // 
            this.btnPreviousPageSV.Enabled = false;
            this.btnPreviousPageSV.Location = new System.Drawing.Point(378, 462);
            this.btnPreviousPageSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreviousPageSV.Name = "btnPreviousPageSV";
            this.btnPreviousPageSV.Size = new System.Drawing.Size(64, 25);
            this.btnPreviousPageSV.TabIndex = 21;
            this.btnPreviousPageSV.Text = "<";
            this.btnPreviousPageSV.UseVisualStyleBackColor = true;
            // 
            // btnNextPageSV
            // 
            this.btnNextPageSV.Enabled = false;
            this.btnNextPageSV.Location = new System.Drawing.Point(694, 467);
            this.btnNextPageSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextPageSV.Name = "btnNextPageSV";
            this.btnNextPageSV.Size = new System.Drawing.Size(64, 22);
            this.btnNextPageSV.TabIndex = 22;
            this.btnNextPageSV.Text = ">";
            this.btnNextPageSV.UseVisualStyleBackColor = true;
            // 
            // btnLastPageSV
            // 
            this.btnLastPageSV.Enabled = false;
            this.btnLastPageSV.Location = new System.Drawing.Point(764, 467);
            this.btnLastPageSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLastPageSV.Name = "btnLastPageSV";
            this.btnLastPageSV.Size = new System.Drawing.Size(64, 24);
            this.btnLastPageSV.TabIndex = 23;
            this.btnLastPageSV.Text = ">>";
            this.btnLastPageSV.UseVisualStyleBackColor = true;
            // 
            // uc_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLastPageSV);
            this.Controls.Add(this.btnNextPageSV);
            this.Controls.Add(this.btnPreviousPageSV);
            this.Controls.Add(this.btnFirstPageSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTimSV);
            this.Controls.Add(this.txtTimSV);
            this.Controls.Add(this.btnTimSV);
            this.Controls.Add(this.dgv_qlsv);
            this.Controls.Add(this.lblStudentPage);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnLamMoiSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnThemSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_QLSV";
            this.Size = new System.Drawing.Size(1054, 618);
            this.Load += new System.EventHandler(this.uc_QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFirstPageSV;
        private System.Windows.Forms.Button btnPreviousPageSV;
        private System.Windows.Forms.Button btnNextPageSV;
        private System.Windows.Forms.Button btnLastPageSV;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
    }
        }
