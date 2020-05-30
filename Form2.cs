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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void btHuy_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.OK)
                Application.Exit();

        }

        private void btTao_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            connnection.Open();
            string sqlCreateAccount = "Insert Into TaiKhoan(TaiKhoan, MatKhau) Value('" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "')";
            SqlCommand cmd2 = new SqlCommand(sqlCreateAccount,connnection);
            cmd2.Parameters.AddWithValue("TenDangNhap", txtTenDangNhap.Text);
            cmd2.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
            cmd2.ExecuteNonQuery();
            //if (txtTenDangNhap.Text == null || txtMatKhau.Text == null)
            //    MessageBox.Show("Vui lòng nhập lại ");
          
            connnection.Close();
        }
    }
}
