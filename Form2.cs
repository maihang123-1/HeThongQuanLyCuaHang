using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        private int CheckPass()
        {
            int count = 0;
            for (int i = 0; i < txtMatKhau.TextLength; i++)
            {
                count++;                
            }
            if (count < 6 && count > 0)
                MessageBox.Show("Mật khẩu tối thiểu 6 ký tự");          
            return count;


        }

        private void btTao_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
            connnection.Open();
            if ((string.IsNullOrEmpty(txtTenDangNhap.Text)) || (string.IsNullOrEmpty(txtMatKhau.Text)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo");
            }
            if (txtTenDangNhap.Text != null && txtMatKhau.Text != null)
            {
                string sqlTen = "Select TenTaiKhoan From TaiKhoan Where TenTaiKhoan='" + txtTenDangNhap.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlTen, connnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if ((dr.Read()))
                {
                    MessageBox.Show("Tài khoản này đã có người sử dụng, vui lòng chọn tài khoản khác", "Thông báo");
                }


                else
                {
                    if (!dr.Read() && CheckPass() >= 6)
                    {
                        dr.Close();
                       
                        string sqlCreateAcc = "Insert Into TaiKhoan Values('"+txtTenDangNhap.Text+"','"+txtMatKhau.Text+"','"+txtGhiChu.Text+"')";
                        SqlCommand cmd1 = new SqlCommand(sqlCreateAcc, connnection);
                        cmd1.Parameters.AddWithValue("TenTaiKhoan", txtTenDangNhap.Text);
                        cmd1.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
                        cmd1.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Tạo tài khoản thành công");
                        connnection.Close();
                        Form3 n3 = new Form3();
                        n3.ShowDialog();

                    }
                }


                
                

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

