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
            this.btThemSP = new System.Windows.Forms.Button();
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
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGia.Location = new System.Drawing.Point(36, 130);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá";
            // 
            // lbSoLuongKho
            // 
            this.lbSoLuongKho.AutoSize = true;
            this.lbSoLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuongKho.Location = new System.Drawing.Point(3, 170);
            this.lbSoLuongKho.Name = "lbSoLuongKho";
            this.lbSoLuongKho.Size = new System.Drawing.Size(91, 17);
            this.lbSoLuongKho.TabIndex = 3;
            this.lbSoLuongKho.Text = "Số lượng kho";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(108, 170);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(77, 20);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(73, 130);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(112, 20);
            this.txtGia.TabIndex = 2;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThoat.Location = new System.Drawing.Point(611, 170);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(76, 41);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 18);
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
            this.button1.Location = new System.Drawing.Point(425, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(532, 129);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(155, 20);
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
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
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
            this.btTongTien.Location = new System.Drawing.Point(425, 74);
            this.btTongTien.Name = "btTongTien";
            this.btTongTien.Size = new System.Drawing.Size(101, 35);
            this.btTongTien.TabIndex = 18;
            this.btTongTien.Text = "Tổng tiền";
            this.btTongTien.UseVisualStyleBackColor = true;
            this.btTongTien.Click += new System.EventHandler(this.btTongTien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(532, 82);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 20);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btThemSP
            // 
            this.btThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThemSP.Location = new System.Drawing.Point(334, 170);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(76, 41);
            this.btThemSP.TabIndex = 21;
            this.btThemSP.Text = "Thêm SP";
            this.btThemSP.UseVisualStyleBackColor = true;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(73, 91);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(112, 20);
            this.txtTenSP.TabIndex = 24;
            this.txtTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(72, 54);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(112, 20);
            this.txtMaSP.TabIndex = 25;
            this.txtMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(274, 54);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(112, 20);
            this.txtDonVi.TabIndex = 26;
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(211, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(202, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(274, 129);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(112, 25);
            this.txtGhiChu.TabIndex = 29;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSoLuongBan
            // 
            this.lbSoLuongBan.AutoSize = true;
            this.lbSoLuongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuongBan.Location = new System.Drawing.Point(202, 94);
            this.lbSoLuongBan.Name = "lbSoLuongBan";
            this.lbSoLuongBan.Size = new System.Drawing.Size(92, 17);
            this.lbSoLuongBan.TabIndex = 30;
            this.lbSoLuongBan.Text = "Số lượng bán";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(310, 91);
            this.txtSoLuongBan.Multiline = true;
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(76, 25);
            this.txtSoLuongBan.TabIndex = 1;
            this.txtSoLuongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btXoa.Location = new System.Drawing.Point(425, 170);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(76, 41);
            this.btXoa.TabIndex = 31;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSua.Location = new System.Drawing.Point(519, 170);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(76, 41);
            this.btSua.TabIndex = 32;
            this.btSua.Text = "Cập nhật";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(425, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btClear.Location = new System.Drawing.Point(550, 17);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(101, 35);
            this.btClear.TabIndex = 34;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 493);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
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
            this.Controls.Add(this.btThemSP);
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
        private System.Windows.Forms.Button btThemSP;
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
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChckChon;
        private System.Windows.Forms.Button btClear;
    }
}