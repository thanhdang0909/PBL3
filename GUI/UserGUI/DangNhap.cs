using DoAnPBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3.View
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTendangnhap.Focus();
                return false;
            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatkhau.Focus();
                return false;
            }
            if (rdoNhanvien.Checked == false && rdoQuanly.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdoQuanly.Focus();
                return false;
            }
            return true;
        }


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                QLTaiKhoan.Instance.Login(txtTendangnhap.Text, txtMatkhau.Text, rdoQuanly.Checked);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTendangnhap.Clear();
            txtMatkhau.Clear();
            rdoNhanvien.Checked = false;
            rdoQuanly.Checked = false;
        }


        private void picEye_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else 
            { 
                txtMatkhau.PasswordChar = '*'; 
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new QuenMatKhau().Show();
        }
    }
}
