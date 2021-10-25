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

namespace BTL_Nhom5
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public void load_Combo()
        {
            dbDataContext db = new dbDataContext();
            var nv = from p in db.ChucVus
                     select p;
            cboChucVu.DataSource = nv;
            cboChucVu.DisplayMember = "TenCv";
            cboChucVu.ValueMember = "MaCV";
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaTK.ResetText();
            txtMatKhau.ResetText();
            cboChucVu.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnectionString = @"Data Source=DESKTOP-HSURQ4A\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnectionString);
            string sqlSelect = "Select *from TaiKhoan where MaTaiKhoan ='" + txtMaTK.Text + "' and MatKhau ='" + txtMatKhau.Text + "' and MaCV='" + cboChucVu.SelectedValue.ToString() + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (txtMaTK.Text == "") MessageBox.Show("Nhập mã tài khoản");
            else if (txtMatKhau.Text == "") MessageBox.Show("Nhập mật khẩu");

            else if (reader.Read() == true)
            {
                if (cboChucVu.Text.ToString().Trim().Equals("Admin"))
                {
                    
                    Form main = new MenuQuanLy();
                    this.Hide();
                    main.ShowDialog();
                    main.Show();
                }
                else if (cboChucVu.Text.ToString().Trim().Equals("Quản lý"))
                {
           
                    Form main = new MenuQuanLy();
                    this.Hide();
                    main.ShowDialog();
                    main.Show();
                }
                else if (cboChucVu.Text.ToString().Trim().Equals("Nhân viên"))
                {
              
                    Form main = new Menu.MenuNhanVien();
                    this.Hide();
                    main.ShowDialog();
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                txtMaTK.ResetText();
                txtMatKhau.ResetText();
                cboChucVu.ResetText();
                txtMaTK.Focus();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            load_Combo();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
