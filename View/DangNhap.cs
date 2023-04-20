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
        public bool CheckDN()
        {
            if (txtTendangnhap.Text == "" && txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (rdoQuanly.Checked == false && rdoNhanvien.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendangnhap.Text;
            string matkhau = txtMatkhau.Text;
            bool vaitro = true;
            if (rdoQuanly.Checked) vaitro = true;
            else if (rdoNhanvien.Checked) vaitro = false;
            if(CheckDN()) QLTKBLL.Instance.DangNhap(tendangnhap, matkhau, vaitro);
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

     
    }
}
