﻿namespace WindowsFormsApp1
{
    partial class Form7
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
            this.dgv7 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbSoLuongKho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbGhichu = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv7
            // 
            this.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv7.Location = new System.Drawing.Point(3, 305);
            this.dgv7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv7.Name = "dgv7";
            this.dgv7.Size = new System.Drawing.Size(896, 388);
            this.dgv7.TabIndex = 0;
            this.dgv7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv7_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 45;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(150, 211);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 35);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(286, 211);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(112, 35);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(430, 211);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(112, 35);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(50, 38);
            this.lbMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(56, 20);
            this.lbMaSP.TabIndex = 4;
            this.lbMaSP.Text = "Mã SP";
            // 
            // lbSoLuongKho
            // 
            this.lbSoLuongKho.AutoSize = true;
            this.lbSoLuongKho.Location = new System.Drawing.Point(50, 154);
            this.lbSoLuongKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuongKho.Name = "lbSoLuongKho";
            this.lbSoLuongKho.Size = new System.Drawing.Size(112, 20);
            this.lbSoLuongKho.TabIndex = 5;
            this.lbSoLuongKho.Text = "Số lượng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(50, 94);
            this.lbGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(34, 20);
            this.lbGia.TabIndex = 7;
            this.lbGia.Text = "Giá";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(454, 38);
            this.lbTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(61, 20);
            this.lbTenSP.TabIndex = 8;
            this.lbTenSP.Text = "Tên SP";
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Location = new System.Drawing.Point(454, 94);
            this.lbDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(53, 20);
            this.lbDonVi.TabIndex = 9;
            this.lbDonVi.Text = "Đơn vị";
            // 
            // lbGhichu
            // 
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Location = new System.Drawing.Point(446, 154);
            this.lbGhichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(64, 20);
            this.lbGhichu.TabIndex = 10;
            this.lbGhichu.Text = "Ghi chú";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(201, 38);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(148, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(201, 94);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(148, 26);
            this.txtGia.TabIndex = 3;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(201, 148);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(148, 26);
            this.txtSoLuongNhap.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(546, 28);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(148, 26);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(546, 89);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(148, 26);
            this.txtDonVi.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(546, 148);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(148, 26);
            this.txtGhiChu.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(772, 211);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(18, 211);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(112, 35);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click_1);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 692);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lbGhichu);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSoLuongKho);
            this.Controls.Add(this.lbMaSP);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgv7);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv7;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbSoLuongKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbGhichu;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btTimKiem;
    }
}