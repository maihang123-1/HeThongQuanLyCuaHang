﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
        }
       
        

        
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
      
       


       

        private void Form3_Load_1(object sender, EventArgs e)
        {
            connnection.Open();
            da = new SqlDataAdapter("Select * From SanPham",connnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgvSanPham.DataSource = dt;
           
            connnection.Close();
        }


        private void btThanhToan_Click(object sender, EventArgs e)
        {

            int Gia = Int32.Parse(txtGia.Text);
            int SoLuong = Int32.Parse(txtSoLuong.Text);
            txtTongTien.Text = (Gia * SoLuong).ToString();
            txtThanhToan.Text += txtTongTien.Text;
            
           
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in dgvSanPham.Rows)
            //{
            //    da = new SqlDataAdapter("Select Gia From SanPham ", connnection);
            //    DataSet txt1 = new DataSet("Select Gia From SanPham ");
            //    DataGridTextBox txt = new DataGridTextBox();
            //    da.Fill(txt1);
            //    da.Dispose();
            //    txtGia.Text = txt1.ToString();
               
            //}
        }

        
    }
}
