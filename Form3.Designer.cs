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
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Chose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btTongTien = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGia.Location = new System.Drawing.Point(12, 404);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoLuong.Location = new System.Drawing.Point(12, 441);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(92, 441);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(112, 20);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(92, 403);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(112, 20);
            this.txtGia.TabIndex = 2;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThoat.Location = new System.Drawing.Point(474, 32);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(109, 41);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 57);
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
            this.button1.Location = new System.Drawing.Point(307, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(414, 447);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(169, 20);
            this.txtThanhToan.TabIndex = 16;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chose});
            this.dgvSanPham.Location = new System.Drawing.Point(5, 121);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(596, 214);
            this.dgvSanPham.TabIndex = 17;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // Chose
            // 
            this.Chose.HeaderText = "";
            this.Chose.Name = "Chose";
            this.Chose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chose.Width = 40;
            // 
            // btTongTien
            // 
            this.btTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btTongTien.Location = new System.Drawing.Point(307, 382);
            this.btTongTien.Name = "btTongTien";
            this.btTongTien.Size = new System.Drawing.Size(101, 35);
            this.btTongTien.TabIndex = 18;
            this.btTongTien.Text = "Tổng tiền";
            this.btTongTien.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(414, 390);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(169, 20);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(94, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên sản phẩm";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 493);
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
            this.Controls.Add(this.lbSoLuong);
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
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chose;
        private System.Windows.Forms.Button btTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
    }
}