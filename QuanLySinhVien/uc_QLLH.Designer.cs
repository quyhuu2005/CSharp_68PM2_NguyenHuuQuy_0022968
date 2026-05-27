namespace QuanLySinhVien
{
    partial class uc_QLLH
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
        private System.Windows.Forms.Label lblTimLop;
        private System.Windows.Forms.TextBox txtTimLop;
        private System.Windows.Forms.Button btnTimLop;
        private System.Windows.Forms.DataGridView dataGridViewLopHoc;
        private System.Windows.Forms.Label lblClassPage;

        private void InitializeComponent()
        {
            this.lblTimLop = new System.Windows.Forms.Label();
            this.txtTimLop = new System.Windows.Forms.TextBox();
            this.btnTimLop = new System.Windows.Forms.Button();
            this.dataGridViewLopHoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClassPage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnLamMoiSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopHoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimLop
            // 
            this.lblTimLop.AutoSize = true;
            this.lblTimLop.Location = new System.Drawing.Point(306, 58);
            this.lblTimLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimLop.Name = "lblTimLop";
            this.lblTimLop.Size = new System.Drawing.Size(127, 13);
            this.lblTimLop.TabIndex = 12;
            this.lblTimLop.Text = "Tìm kiếm (Tên / Mã Lớp):";
            // 
            // txtTimLop
            // 
            this.txtTimLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimLop.Location = new System.Drawing.Point(309, 73);
            this.txtTimLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimLop.Name = "txtTimLop";
            this.txtTimLop.Size = new System.Drawing.Size(311, 20);
            this.txtTimLop.TabIndex = 13;
            // 
            // btnTimLop
            // 
            this.btnTimLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimLop.ForeColor = System.Drawing.Color.White;
            this.btnTimLop.Location = new System.Drawing.Point(625, 67);
            this.btnTimLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimLop.Name = "btnTimLop";
            this.btnTimLop.Size = new System.Drawing.Size(116, 30);
            this.btnTimLop.TabIndex = 14;
            this.btnTimLop.Text = "Tìm";
            this.btnTimLop.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLopHoc
            // 
            this.dataGridViewLopHoc.AllowUserToAddRows = false;
            this.dataGridViewLopHoc.AllowUserToDeleteRows = false;
            this.dataGridViewLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewLopHoc.Location = new System.Drawing.Point(309, 121);
            this.dataGridViewLopHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewLopHoc.MultiSelect = false;
            this.dataGridViewLopHoc.Name = "dataGridViewLopHoc";
            this.dataGridViewLopHoc.ReadOnly = true;
            this.dataGridViewLopHoc.RowHeadersWidth = 51;
            this.dataGridViewLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLopHoc.Size = new System.Drawing.Size(493, 353);
            this.dataGridViewLopHoc.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Lớp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Lớp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Giáo Viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Lượng SV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblClassPage
            // 
            this.lblClassPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClassPage.AutoSize = true;
            this.lblClassPage.Location = new System.Drawing.Point(502, 496);
            this.lblClassPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassPage.Name = "lblClassPage";
            this.lblClassPage.Size = new System.Drawing.Size(107, 13);
            this.lblClassPage.TabIndex = 16;
            this.lblClassPage.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblMaSinhVien);
            this.groupBox2.Controls.Add(this.txtMaSinhVien);
            this.groupBox2.Controls.Add(this.lblHoTen);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.lblNgaySinh);
            this.groupBox2.Location = new System.Drawing.Point(3, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 292);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lớp học";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 176);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(8, 53);
            this.lblMaSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(39, 13);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã ID:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(10, 67);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(241, 20);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(8, 108);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Mã lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(9, 123);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(241, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(5, 162);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(46, 13);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Tên lớp:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(8, 217);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(47, 13);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ghi chú:";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Location = new System.Drawing.Point(3, 413);
            this.btnXoaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(124, 40);
            this.btnXoaSV.TabIndex = 22;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = false;
            // 
            // btnLamMoiSV
            // 
            this.btnLamMoiSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLamMoiSV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSV.Location = new System.Drawing.Point(141, 413);
            this.btnLamMoiSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.Size = new System.Drawing.Size(134, 40);
            this.btnLamMoiSV.TabIndex = 23;
            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.UseVisualStyleBackColor = false;
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSuaSV.ForeColor = System.Drawing.Color.White;
            this.btnSuaSV.Location = new System.Drawing.Point(141, 357);
            this.btnSuaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(134, 45);
            this.btnSuaSV.TabIndex = 21;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = false;
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemSV.ForeColor = System.Drawing.Color.White;
            this.btnThemSV.Location = new System.Drawing.Point(3, 357);
            this.btnThemSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(124, 45);
            this.btnThemSV.TabIndex = 20;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 483);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 27);
            this.button4.TabIndex = 28;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 483);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 27);
            this.button3.TabIndex = 27;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 483);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 27);
            this.button2.TabIndex = 26;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 465);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 45);
            this.button5.TabIndex = 29;
            this.button5.Text = "Xem danh sách sinh viên";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // uc_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnLamMoiSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.lblTimLop);
            this.Controls.Add(this.txtTimLop);
            this.Controls.Add(this.btnTimLop);
            this.Controls.Add(this.dataGridViewLopHoc);
            this.Controls.Add(this.lblClassPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_QLLH";
            this.Size = new System.Drawing.Size(835, 621);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopHoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnLamMoiSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}
