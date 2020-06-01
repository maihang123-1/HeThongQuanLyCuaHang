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
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
            connnection.Open();
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                string sqlTen = "Select TenTaiKhoan From TaiKhoan Where TenTaiKhoan='" + txtTenDangNhap.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlTen, connnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tài khoản này đã có người sử dụng, vui lòng chọn tài khoản khác", "Thông báo");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        MessageBox.Show("HAHA");
                        MessageBox.Show("Vui lòng nhập lại thông tin ", "Thông báo");
                    }
                }


            }
           


            //else if (tk2 == sqlTen)
            //{
            //    //string tk2 = txtTenDangNhap.Text;
            //    //string sqlTen = "Select * From TaiKhoanNguoiDung Where Email = '" + tk2 + "'";              
            //        MessageBox.Show("Tên tài khoản này đã tồn tại");
            //}
            //else if (email2== sqlEmail)
            //    MessageBox.Show("Địa chỉ Email này đã tồn tại");

            //else
            //{
            //    SqlCommand cmd2 = new SqlCommand(sqlCreateAccount, connnection);
            //    cmd2.Parameters.AddWithValue("TaiKhoan", txtTenDangNhap.Text);
            //    cmd2.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
            //    cmd2.Parameters.AddWithValue("Email", txtEmail.Text);
            //    //cmd2.ExecuteNonQuery();

            //    //cmd2.ExecuteReader();
            //    MessageBox.Show("Tạo tài khoản thành công");
            //    this.Close();
            //}
            connnection.Close();
        }
    }
}
