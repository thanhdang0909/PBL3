using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using Guna.UI2.WinForms;
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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendangnhap.Text;
            string kytu = txtKytu.Text;
            string matkhaumoi = txtMatkhaumoi.Text;
            string matkhauxacnhan = txtXacnhanmatkhau.Text;
            if (QLTaiKhoan.Instance.ForgotPassword(tendangnhap, kytu, matkhaumoi, matkhauxacnhan))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PasswordChar(Guna2TextBox txt)
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
        private void picEye1_Click(object sender, EventArgs e)
        {
            PasswordChar(txtKytu);
        }

        private void picEye2_Click(object sender, EventArgs e)
        {
            PasswordChar(txtMatkhaumoi);
        }

        private void picEye3_Click(object sender, EventArgs e)
        {
            PasswordChar(txtXacnhanmatkhau);
        }
    }
}
