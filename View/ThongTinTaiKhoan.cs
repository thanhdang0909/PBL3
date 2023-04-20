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
                //string maTK = txtMaTK.Text;
                //string tenDN = txtTendangnhap.Text;
                //string tenNV = txtTennguoidung.Text;
                //string diaChi = txtDiachi.Text;
                //QLTKBLL.Instance.UpdateTTTK(maTK, tenDN, tenNV, diaChi);
         }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
