using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection connnection = new SqlConnection(@"Data Source=MKB\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");

        public void HienThi()
        {
            string sqlSelect = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, connnection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSP.DataSource = dt;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connnection.Open();
            HienThi();
            connnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@DonVi,@SoLuong,@GhiChu)";
            SqlCommand cmd = new SqlCommand(sqlInsert, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSp.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Thêm sản phẩm thành công");
        }

    }
}
