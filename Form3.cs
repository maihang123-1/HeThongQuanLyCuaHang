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

        SqlConnection connnection = new SqlConnection(@"Data Source=MKB\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
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
            SqlCommand cmd = new SqlCommand(sqlSelect, connnection);
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





        
        
        private void btTongTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm trước");
            else
            if (string.IsNullOrEmpty(txtSoLuongBan.Text))
                MessageBox.Show("Vui lòng nhập số lượng bán");

            else
            {
<<<<<<< HEAD
                int b;
                bool o = int.TryParse(txtSoLuongBan.Text, out b);

                if (!o)
                    MessageBox.Show("Vui lòng nhập số lượng là một số");
                else
                {
                    int Gia = Int32.Parse(txtGia.Text);
                    int SoLuongBan = Int32.Parse(txtSoLuongBan.Text);
                    txtTongTien.Text = (Gia * SoLuongBan).ToString();
=======
                int Gia = Int32.Parse(txtGia.Text);
                int SoLuongBan = Int32.Parse(txtSoLuongBan.Text);
                txtTongTien.Text = (Gia * SoLuongBan).ToString();
                int a;
                bool d = Int32.TryParse(txtThanhToan.Text,out a);
                a += Int32.Parse(txtTongTien.Text);
                txtThanhToan.Text = (a).ToString();

                

>>>>>>> 1197a3816c843d2339f95c04946d8eed52f8d46e

                    int a;
                    // int b = Int32.Parse(txtTongTien.Text);
                    bool d = Int32.TryParse(txtThanhToan.Text, out a);
                    a += Int32.Parse(txtTongTien.Text);
                    txtThanhToan.Text = (a).ToString();


                } }


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThanhToan.Text))
                MessageBox.Show("Vui lòng nhập thông tin đơn hàng");

            else
            {
                DialogResult kq3 = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
                if (kq3 == DialogResult.Yes)
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                    Application.Exit();
                }
            }
                
        }

       

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgvSanPham.CurrentCell.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[index].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[index].Cells["TenSP"].Value.ToString();
            txtGia.Text = dgvSanPham.Rows[index].Cells["Gia"].Value.ToString();
            txtDonVi.Text = dgvSanPham.Rows[index].Cells["DonVi"].Value.ToString();
            txtSoLuong.Text = dgvSanPham.Rows[index].Cells["SoLuong"].Value.ToString();
            txtGhiChu.Text = dgvSanPham.Rows[index].Cells["GhiChu"].Value.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

<<<<<<< HEAD
=======
        private void btClear_Click(object sender, EventArgs e)
        {
            //txtMaSP.Text = null;
            //txtTenSP.Text = null;
            //txtDonVi.Text = null;
            //txtGhiChu.Text = null;
            //txtSoLuongBan.Text = null;
            //txtGia.Text = null;
            //txtTongTien.Text = null;
            //txtThanhToan.Text = null;
        }

>>>>>>> 1197a3816c843d2339f95c04946d8eed52f8d46e
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 n7 = new Form7();
            n7.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void btClear_Click_1(object sender, EventArgs e)
        {
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDonVi.Text = null;
            txtGhiChu.Text = null;
            txtSoLuongBan.Text = null;
            txtGia.Text = null;
            txtTongTien.Text = null;
            txtThanhToan.Text = null;
            txtSoLuong.Text = null;
        }
>>>>>>> 1197a3816c843d2339f95c04946d8eed52f8d46e
    }
}
