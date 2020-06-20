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
    public partial class Form4 : Form
    { //Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True
        public Form4()
        {
            InitializeComponent();
            
        }
        SqlConnection connnection = new SqlConnection(@"Data Source=MKB\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
        //SqlDataAdapter da;
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
        public void HienThi()
        {
            string sqlSelect = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, connnection);
            SqlDataReader dr4 = cmd.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(dr4);
            dgvThongKe.DataSource = dt4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connnection.Open();
            HienThi();
            connnection.Close();
        }
    }
}
