﻿namespace WindowsFormsApp1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtXacnhanMk = new System.Windows.Forms.TextBox();
            this.lbMkMoi = new System.Windows.Forms.Label();
            this.lbXacNhanMk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoanMoi = new System.Windows.Forms.TextBox();
            this.btDoiMk = new System.Windows.Forms.Button();
            this.btThoatF6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mật khẩu mới";
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(139, 148);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(133, 20);
            this.txtMatkhaumoi.TabIndex = 3;
            // 
            // txtXacnhanMk
            // 
            this.txtXacnhanMk.Location = new System.Drawing.Point(139, 185);
            this.txtXacnhanMk.Name = "txtXacnhanMk";
            this.txtXacnhanMk.Size = new System.Drawing.Size(133, 20);
            this.txtXacnhanMk.TabIndex = 4;
            // 
            // lbMkMoi
            // 
            this.lbMkMoi.AutoSize = true;
            this.lbMkMoi.Location = new System.Drawing.Point(12, 155);
            this.lbMkMoi.Name = "lbMkMoi";
            this.lbMkMoi.Size = new System.Drawing.Size(71, 13);
            this.lbMkMoi.TabIndex = 3;
            this.lbMkMoi.Text = "Mật khẩu mới";
            // 
            // lbXacNhanMk
            // 
            this.lbXacNhanMk.AutoSize = true;
            this.lbXacNhanMk.Location = new System.Drawing.Point(12, 192);
            this.lbXacNhanMk.Name = "lbXacNhanMk";
            this.lbXacNhanMk.Size = new System.Drawing.Size(113, 13);
            this.lbXacNhanMk.TabIndex = 4;
            this.lbXacNhanMk.Text = "Xác nhận lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // txtTaiKhoanMoi
            // 
            this.txtTaiKhoanMoi.Location = new System.Drawing.Point(139, 80);
            this.txtTaiKhoanMoi.Name = "txtTaiKhoanMoi";
            this.txtTaiKhoanMoi.Size = new System.Drawing.Size(133, 20);
            this.txtTaiKhoanMoi.TabIndex = 1;
            // 
            // btDoiMk
            // 
            this.btDoiMk.Location = new System.Drawing.Point(43, 241);
            this.btDoiMk.Name = "btDoiMk";
            this.btDoiMk.Size = new System.Drawing.Size(101, 23);
            this.btDoiMk.TabIndex = 5;
            this.btDoiMk.Text = "Đổi mật khẩu";
            this.btDoiMk.UseVisualStyleBackColor = true;
            this.btDoiMk.Click += new System.EventHandler(this.btDoiMk_Click);
            // 
            // btThoatF6
            // 
            this.btThoatF6.Location = new System.Drawing.Point(150, 241);
            this.btThoatF6.Name = "btThoatF6";
            this.btThoatF6.Size = new System.Drawing.Size(102, 23);
            this.btThoatF6.TabIndex = 6;
            this.btThoatF6.Text = "Thoát";
            this.btThoatF6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ Email";
            // 
            // txtDiaChiEmail
            // 
            this.txtDiaChiEmail.Location = new System.Drawing.Point(139, 117);
            this.txtDiaChiEmail.Name = "txtDiaChiEmail";
            this.txtDiaChiEmail.Size = new System.Drawing.Size(133, 20);
            this.txtDiaChiEmail.TabIndex = 2;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 288);
            this.Controls.Add(this.txtDiaChiEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btThoatF6);
            this.Controls.Add(this.btDoiMk);
            this.Controls.Add(this.txtTaiKhoanMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbXacNhanMk);
            this.Controls.Add(this.lbMkMoi);
            this.Controls.Add(this.txtXacnhanMk);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ĐỔI MẬT KHẨU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMkMoi;
        private System.Windows.Forms.Label lbXacNhanMk;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMatkhaumoi;
        public System.Windows.Forms.TextBox txtXacnhanMk;
        protected internal System.Windows.Forms.TextBox txtTaiKhoanMoi;
        private System.Windows.Forms.Button btDoiMk;
        private System.Windows.Forms.Button btThoatF6;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox txtDiaChiEmail;
    }
}