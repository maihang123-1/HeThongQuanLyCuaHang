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


        private void Delete()
        {
            //string sqlDelete = "Delete SanPham Where ";
        }
        
        private void btThemSP_Click(object sender, EventArgs e)
        {
            
            
                connnection.Open();
                //txtMaSP.ReadOnly = false;
                //txtTenSP.ReadOnly = false;
                //txtGia.ReadOnly = false;
                //txtSoLuong.ReadOnly = false;
                //txtDonVi.ReadOnly = false;
                string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@DonVi,@SoLuong,@GhiChu)";
                SqlCommand cmd = new SqlCommand(sqlInsert, connnection);
                cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("Gia", txtGia.Text);
                cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
                cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm thành công");
                HienThi();
                connnection.Close();
            
        }

        private void btTongTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuongBan.Text))
                MessageBox.Show("Vui lòng nhập số lượng bán");
            else
            {
                int Gia = Int32.Parse(txtGia.Text);
                int SoLuongBan = Int32.Parse(txtSoLuongBan.Text);
                txtTongTien.Text = (Gia * SoLuongBan).ToString();
                txtThanhToan.Text += (txtTongTien.Text);




            }


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

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
           
            if(ClXoa.Selected)
            {
                Delete();
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            connnection.Open();
            string sqlDelete = "Delete From SanPham Where MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDelete, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDonVi.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa sản phẩm thành công");
            HienThi();
            connnection.Close();
        }
    }
}
