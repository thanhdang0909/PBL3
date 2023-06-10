using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using Guna.UI2.WinForms;
//using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtTendangnhap.Text = QLTaiKhoan.Instance.TenDangNhap;
        }
       
        public void SetPasswordChar(Guna2TextBox txt)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
            }
            else
            {
                txt.PasswordChar = '*';
            }
        }    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetPasswordChar(txtMatkhaucu);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetPasswordChar(txtNhaplaimatkhau);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetPasswordChar(txtMatkhaumoi);
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtMatkhaucu.Text;
            string matkhaumoi = txtMatkhaumoi.Text;
            string xacnhanmatkhau = txtNhaplaimatkhau.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(QLTaiKhoan.Instance.SetPassWord(matkhaucu, matkhaumoi, xacnhanmatkhau))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }
        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
    }
}
