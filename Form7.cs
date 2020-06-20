using System;
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
    public partial class Form7 : Form
    {
        SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
        SqlDataAdapter da;

        public Form7()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string sqlSelect = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, connnection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv7.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            connnection.Open();
            HienThi();

            connnection.Close();
        }
        private void dgv7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv7.CurrentCell.RowIndex;
            txtMaSP.Text = dgv7.Rows[index].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgv7.Rows[index].Cells["TenSP"].Value.ToString();
            txtGia.Text = dgv7.Rows[index].Cells["Gia"].Value.ToString();
            txtDonVi.Text = dgv7.Rows[index].Cells["DonVi"].Value.ToString();
            txtSoLuongNhap.Text = dgv7.Rows[index].Cells["SoLuong"].Value.ToString();
            txtGhiChu.Text = dgv7.Rows[index].Cells["GhiChu"].Value.ToString();
        }

       

        private void btXoa_Click(object sender, EventArgs e)
        {
            connnection.Open();
            string sqlDelete = "Delete From SanPham Where MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDelete, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuongNhap.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa sản phẩm thành công");
            HienThi();
            connnection.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            connnection.Open();
           
            string sqlUpdate = "Update SanPham Set TenSP =@TenSP, Gia=@Gia, DonVi=@DonVi, SoLuong=@SoLuong, GhiChu=@GhiChu Where MaSP=@MaSP ";
            SqlCommand cmd = new SqlCommand(sqlUpdate, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuongNhap.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
            HienThi();
            connnection.Close();
        }

       

        private void btThem_Click_1(object sender, EventArgs e)
        {
            connnection.Open();

            string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@DonVi,@SoLuong,@GhiChu)";
            SqlCommand cmd = new SqlCommand(sqlInsert, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuongNhap.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phẩm thành công");
            HienThi();
            connnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDonVi.Text = null;
            txtGhiChu.Text = null;
            txtSoLuongNhap.Text = null;
            txtGia.Text = null;
            
        }
    }
}
