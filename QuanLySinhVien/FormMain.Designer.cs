using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    partial class FormMain
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

        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Button btnQuanLyLopHoc;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnQuanLyLopHoc = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.BackColor = System.Drawing.Color.White;
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuanLySinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(0, 26);
            this.btnQuanLySinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(130, 33);
            this.btnQuanLySinhVien.TabIndex = 0;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = false;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);
            // 
            // btnQuanLyLopHoc
            // 
            this.btnQuanLyLopHoc.BackColor = System.Drawing.Color.White;
            this.btnQuanLyLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuanLyLopHoc.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyLopHoc.Location = new System.Drawing.Point(136, 26);
            this.btnQuanLyLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            this.btnQuanLyLopHoc.Size = new System.Drawing.Size(136, 33);
            this.btnQuanLyLopHoc.TabIndex = 1;
            this.btnQuanLyLopHoc.Text = "Quản lý lớp học";
            this.btnQuanLyLopHoc.UseVisualStyleBackColor = false;
            this.btnQuanLyLopHoc.Click += new System.EventHandler(this.btnQuanLyLopHoc_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Location = new System.Drawing.Point(0, 85);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1190, 652);
            this.panelContent.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Quản lý";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1191, 741);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnQuanLyLopHoc);
            this.Controls.Add(this.btnQuanLySinhVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
