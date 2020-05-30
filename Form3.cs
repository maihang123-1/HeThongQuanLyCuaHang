using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btThanhToan_Click_1(object sender, EventArgs e)
        {
            int Gia = Int32.Parse(txtGia.Text);
            int SoLuong = Int32.Parse(txtSoLuong.Text);
            txtThanhToan.Text = (Gia * SoLuong).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        
    }
}
