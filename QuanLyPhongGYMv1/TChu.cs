using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongGYMv1
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
     

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            nutDangNhap.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            nutDangNhap.BackColor = SystemColors.ButtonShadow;
        }


        private void nutDangNhap_Click(object sender, EventArgs e)
        {
            Dangnhapv1 mainForm = new Dangnhapv1();  // Khởi tạo form đích
            mainForm.Show();

            // Ẩn Form1 thay vì Close
            this.Hide();

            // Khi Form2 đóng, ta đóng Form1 => kết thúc app
            mainForm.FormClosed += (s, args) => this.Close();

        }

        
    }
}
