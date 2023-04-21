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
       
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendangnhap.Text;
            string matkhau = txtMatkhau.Text;
            bool vaitro = true;

            if (rdoQuanly.Checked)
            {
                vaitro = true;
            }
            else if (rdoNhanvien.Checked)
            {
                vaitro = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quyền đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            QLTKBLL.Instance.DangNhap(tendangnhap, matkhau, vaitro);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();

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
    }
}
