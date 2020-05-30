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
        public Form3()
        {
            InitializeComponent();
        }
        public void ShowMessagebox()
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
                this.Close();

        }
        

        //private void btThanhToan_Click(object sender, EventArgs e)
        //{
        //    int Gia;
        //    int SoLuong;
        //    int ThanhToan;
        //    Gia = Convert.ToInt16(txtGia.Text);
        //    SoLuong = Convert.ToInt16(txtSoLuong.Text);
        //    ThanhToan = Convert.ToInt16(txtThanhToan.Text);
        //    int TongTien;
        //    TongTien = (Gia * SoLuong);
        //    txtThanhToan.Text = TongTien.ToString();
         

        //    int Gia = Convert.ToInt16(txtGia.Text);
        //    int SoLuong = Convert.ToInt16(txtSoLuong.Text);
        //    txtThanhToan.Text = (Gia * SoLuong).ToString();
        //    int Gia = Int32.Parse(txtGia.Text);
        //    int SoLuong = Int32.Parse(txtSoLuong.Text);
        //    txtThanhToan.Text = (Gia * SoLuong).ToString();
        //}




        //private void btThongKe_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Form4 n4 = new Form4();
        //    n4.ShowDialog();
        //}

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }

        

        private void btThanhToan_Click(object sender, EventArgs e)
        {

            int Gia = Int32.Parse(txtGia.Text);
            int SoLuong = Int32.Parse(txtSoLuong.Text);
            txtTongTien.Text = (Gia * SoLuong).ToString();
            txtThanhToan.Text += txtTongTien.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            connnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Gia From SanPham", connnection);
            da.Fill(dt);
            //string sqlItem = "Select SanPham From SanPham";
            //SqlCommand cmd3 = new SqlCommand(sqlItem, connnection);
            //cbbxSanPham.Items =;
            //string sqlGia = "Select ";
            //txtGia.Text = "";
            cbbxSanPham.DataSource = dt;
            cbbxSanPham.DisplayMember = "SanPham";
            cbbxSanPham.ValueMember = "SanPham";

            connnection.Close();
        }

        private void cbbxSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            connnection.Open();
            
          
            SqlDataAdapter da = new SqlDataAdapter("Select * From SanPham", connnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //string sqlItem = "Select SanPham From SanPham";
            //SqlCommand cmd3 = new SqlCommand(sqlItem, connnection);
            //cbbxSanPham.Items =;
            //string sqlGia = "Select ";
            //txtGia.Text = "";
            
            cbbxSanPham.DataSource = dt;
            cbbxSanPham.DisplayMember = "SanPham";
            cbbxSanPham.ValueMember = "SanPham";

            connnection.Close();
        }

    }
}
