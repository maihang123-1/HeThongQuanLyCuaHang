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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btDoiMk_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
            string sql = "Select TenTaiKhoan From TaiKhoan='" + txtTaiKhoan.Text + "'";
            connnection.Open();
            string sqlSelectDt = "Update TaiKhoan Set TenTaiKhoan='" + txtTaiKhoan.Text + "',MatKhau='" + txtMatkhaumoi.Text + "'";
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatkhaumoi.Text) || string.IsNullOrEmpty(txtXacnhanMk.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            else if (txtMatkhaumoi.Text != txtXacnhanMk.Text)
                MessageBox.Show("Xác nhận lại mật khẩu thất bại, vui lòng nhập lại", "Thông báo");
            else
            {
                
                SqlCommand cmd = new SqlCommand(sql,connnection);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == false)
                {
                    MessageBox.Show("Tài khoản này không tồn tại", "Thông báo");
                    
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand(sqlSelectDt, connnection);
                    cmd1.ExecuteNonQuery();
                }
            }
               
                

            
        }

        private void btThoatF6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
