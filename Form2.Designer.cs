namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btTao = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenDangNhap.Location = new System.Drawing.Point(70, 156);
            this.lbTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lbTenDangNhap.TabIndex = 0;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(70, 225);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(208, 158);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(222, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtMatKhau.Location = new System.Drawing.Point(208, 225);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(222, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // btTao
            // 
            this.btTao.Location = new System.Drawing.Point(208, 315);
            this.btTao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(97, 41);
            this.btTao.TabIndex = 3;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(335, 315);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 41);
            this.btHuy.TabIndex = 5;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(229, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "TẠO TÀI KHOẢN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO TÀI KHOẢN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
    }
}