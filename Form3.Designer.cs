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
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSoLuongKho = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.ChckChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btTongTien = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbSoLuongBan = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGia.Location = new System.Drawing.Point(36, 146);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá";
            // 
            // lbSoLuongKho
            // 
            this.lbSoLuongKho.AutoSize = true;
            this.lbSoLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuongKho.Location = new System.Drawing.Point(235, 144);
            this.lbSoLuongKho.Name = "lbSoLuongKho";
            this.lbSoLuongKho.Size = new System.Drawing.Size(91, 17);
            this.lbSoLuongKho.TabIndex = 3;
            this.lbSoLuongKho.Text = "Số lượng kho";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(332, 143);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(54, 20);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(75, 143);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(112, 20);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThoat.Location = new System.Drawing.Point(446, 171);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(76, 41);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(107, 21);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(433, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(540, 121);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(142, 20);
            this.txtThanhToan.TabIndex = 16;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChckChon});
            this.dgvSanPham.Location = new System.Drawing.Point(4, 222);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(695, 269);
            this.dgvSanPham.TabIndex = 17;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // ChckChon
            // 
            this.ChckChon.HeaderText = "";
            this.ChckChon.Name = "ChckChon";
            this.ChckChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChckChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChckChon.Width = 40;
            // 
            // btTongTien
            // 
            this.btTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btTongTien.Location = new System.Drawing.Point(433, 57);
            this.btTongTien.Name = "btTongTien";
            this.btTongTien.Size = new System.Drawing.Size(101, 35);
            this.btTongTien.TabIndex = 18;
            this.btTongTien.Text = "Tổng tiền";
            this.btTongTien.UseVisualStyleBackColor = true;
            this.btTongTien.Click += new System.EventHandler(this.btTongTien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(540, 65);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(142, 20);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(75, 104);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(112, 20);
            this.txtTenSP.TabIndex = 4;
            this.txtTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(75, 65);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(112, 20);
            this.txtMaSP.TabIndex = 2;
            this.txtMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(332, 64);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(54, 20);
            this.txtDonVi.TabIndex = 3;
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(278, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(10, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(75, 182);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(112, 25);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSoLuongBan
            // 
            this.lbSoLuongBan.AutoSize = true;
            this.lbSoLuongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuongBan.Location = new System.Drawing.Point(234, 104);
            this.lbSoLuongBan.Name = "lbSoLuongBan";
            this.lbSoLuongBan.Size = new System.Drawing.Size(92, 17);
            this.lbSoLuongBan.TabIndex = 30;
            this.lbSoLuongBan.Text = "Số lượng bán";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(332, 105);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(54, 20);
            this.txtSoLuongBan.TabIndex = 1;
            this.txtSoLuongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(540, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 31;
            this.button2.Text = "Quản lý sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btClear.Location = new System.Drawing.Point(350, 171);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(76, 41);
            this.btClear.TabIndex = 32;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 493);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSoLuongBan);
            this.Controls.Add(this.lbSoLuongBan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btTongTien);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbSoLuongKho);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.txtGia);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSoLuongKho;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbSoLuongBan;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChckChon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btClear;
    }
}