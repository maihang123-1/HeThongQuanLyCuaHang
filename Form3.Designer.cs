namespace WindowsFormsApp1
{
    partial class Form3
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
            this.btThanhToan = new System.Windows.Forms.Button();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.combSanPham = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThanhToan.Location = new System.Drawing.Point(12, 357);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(101, 35);
            this.btThanhToan.TabIndex = 0;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click_1);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSanPham.Location = new System.Drawing.Point(30, 186);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(72, 17);
            this.lbSanPham.TabIndex = 1;
            this.lbSanPham.Text = "Sản phẩm";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGia.Location = new System.Drawing.Point(30, 239);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuong.Location = new System.Drawing.Point(30, 290);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(145, 287);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(145, 236);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(168, 20);
            this.txtGia.TabIndex = 2;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // combSanPham
            // 
            this.combSanPham.FormattingEnabled = true;
            this.combSanPham.Items.AddRange(new object[] {
            "Nước suối tinh khiết",
            "Nước khoáng Lavie",
            "Coca Cola",
            "Cam ép",
            "Revise chanh muối",
            "Bia Tiger",
            "Bia Heniken",
            "Nước ép táo"});
            this.combSanPham.Location = new System.Drawing.Point(145, 182);
            this.combSanPham.Name = "combSanPham";
            this.combSanPham.Size = new System.Drawing.Size(168, 21);
            this.combSanPham.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThoat.Location = new System.Drawing.Point(439, 344);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(109, 41);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(145, 365);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(178, 20);
            this.txtThanhToan.TabIndex = 5;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(193, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.combSanPham);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.txtGia);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox combSanPham;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}