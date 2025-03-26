using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;


namespace QuanLyPhongGYMv1
{
    public partial class NhapThongTin : Form
    {
        private DBGYM dbGym;

        public NhapThongTin()
        {
            InitializeComponent();
            dbGym = new DBGYM();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gọi phương thức LoadMemberships khi form load
            try
            {
                DataTable dt = dbGym.GetMembershipPackages();
                goiTap.Items.Clear();
                goiTap.Items.Add("-- Chọn gói tập --");

                foreach (DataRow row in dt.Rows)
                {
                    goiTap.Items.Add(new ComboBoxItem(row["MembershipName"].ToString(), (int)row["MembershipID"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải gói tập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void goiTap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (goiTap.SelectedIndex > 0)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)goiTap.SelectedItem;
                MessageBox.Show($"Bạn đã chọn gói tập: {selectedItem.Text} (ID: {selectedItem.Value})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nutHuy_Click(object sender, EventArgs e)
        {
            // Xóa các trường nhập liệu
            textHoten.Clear();
            textDiaChi.Clear();
            textSDT.Clear();
            goiTap.SelectedIndex = 0;
        }

        private void nutLuu_Click(object sender, EventArgs e)
        {
            // Lưu thông tin khách hàng
            string fullName = textHoten.Text.Trim();
            string phoneNumber = textSDT.Text.Trim();
            DateTime startDate = DateTime.Now; // Giả sử ngày bắt đầu là ngày hiện tại
            int? membershipID = goiTap.SelectedIndex > 0 ? ((ComboBoxItem)goiTap.SelectedItem).Value : (int?)null;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbGym.AddCustomer(fullName, phoneNumber, startDate, membershipID);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
