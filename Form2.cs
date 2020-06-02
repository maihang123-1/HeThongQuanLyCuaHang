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
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
            
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
            connnection.Open();
            if( string.IsNullOrEmpty(txtMatKhau.Text))
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
                    if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        MessageBox.Show("HAHA");
                        MessageBox.Show("Vui lòng nhập lại thông tin ", "Thông báo");
                    }
                    //else if((Int32.Parse( txtMatKhau.Text) <6))
                    //{
                    //    MessageBox.Show("Mật khẩu tối thiểu 6 ký tự, vui lòng nhập lại");
                    //}    
                    else
                    {
                        string sqlCreate = "Inser Into TaiKhoan(TenTaiKhoan,MatKhau) Values('" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "')";
                        

                        SqlCommand cmd2 = new SqlCommand(sqlCreate, connnection);
                        cmd2.CommandText = sqlCreate;
                        cmd2.Parameters.AddWithValue("TenTaiKhoan", txtTenDangNhap.Text);
                        cmd2.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                }


            }
           


           

          
            connnection.Close();
        }
    }
}
