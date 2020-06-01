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
using System.Runtime.Remoting.Messaging;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 n2 = new Form2();
            n2.ShowDialog();
            //this.Show();
        }

       

        private void btLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            try {
                
                connnection.Open();
                string tk = txtUsername.Text;
                string mk = txtPassword.Text;
                string sql = "Select * From TaiKhoan Where TenTaiKhoan ='" + tk + "'and Matkhau ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql,connnection);
                SqlDataReader dt = cmd.ExecuteReader();
                if(dt.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form3 n3 = new Form3();
                    n3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connnection.Close();
                // dùng cho câu lệnh insert, update
               // cmd.ExecuteNonQuery();
             }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối ");
            }
            

        }

        private void chckShow_CheckedChanged(object sender, EventArgs e)
        {
            //if (chckShow.Checked)
            //    txtPassword.PasswordChar = '*';
            //else
                txtPassword.UseSystemPasswordChar = chckShow.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult kq= MessageBox.Show("Bạn có muốn reset lại password ??", "Thông báo",MessageBoxButtons.YesNo);
            if(kq==DialogResult.OK)
            {
                this.Hide();
                Form6 n6 = new Form6();
                n6.ShowDialog();
                
                //string sqlReset = "Update TaiKhoan Set MatKhau ="";
            }    

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.OK)
            //    e.Cancel = true;
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.OK)
                Application.Exit();

        }
    }
}
