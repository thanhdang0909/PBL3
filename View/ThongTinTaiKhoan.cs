using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
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
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            Show();
        }

        public void Show()
        {
            NHANVIEN nv = QLTKBLL.Instance.GetUserByTDN();
            txtMaTK.Text = nv.maTK;
            txtTendangnhap.Text = nv.SDT;
            txtTennguoidung.Text = nv.tenNV;
            txtDiachi.Text = nv.diaChi;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string matk = txtMaTK.Text;
            string tendangnhap = txtTendangnhap.Text;
            string tennguoidung = txtTennguoidung.Text;
            string diachi = txtDiachi.Text;
            QLTKBLL.Instance.UpdateThongtintaikhoan(matk, tendangnhap, tennguoidung, diachi);
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
