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
      
       
        public void HienThi()
        {
            string sqlSelect = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect,connnection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSanPham.DataSource = dt;
        }

       

        private void Form3_Load_1(object sender, EventArgs e)
        {
            connnection.Open();
            HienThi();
            
            
           
            connnection.Close();
        }


        
        
        private void btThemSP_Click(object sender, EventArgs e)
        {
            connnection.Open();
            string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@DonVi,@SoLuong,@GhiChu)";
            SqlCommand cmd = new SqlCommand(sqlInsert, connnection);
            cmd.Parameters.AddWithValue("MaSP",txtMaSP.Text );
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phẩm thành công");
            HienThi();
            //this.Hide();
            //Form5 n5 = new Form5();
            //n5.ShowDialog();

            connnection.Close();
        }

        private void btTongTien_Click(object sender, EventArgs e)
        {

            int Gia = Int32.Parse(txtGia.Text);
            int SoLuong = Int32.Parse(txtSoLuong.Text);           
            txtTongTien.Text = (Gia * SoLuong).ToString();
            txtThanhToan.Text += txtTongTien.Text;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq3 = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
            if (kq3 == DialogResult.Yes)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                Application.Exit();
            }    
                
        }
    }
}
