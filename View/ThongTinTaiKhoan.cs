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
            ShowTTTK();
        }

        public void ShowTTTK()
        {
            NHANVIEN nv = QLTKBLL.Instance.GetNVByTDN();
            txtMaTK.Text = nv.maTK;
            txtTenDN.Text = nv.SDT;
            txtTenNV.Text = nv.tenNV;
            txtDiaChi.Text = nv.diaChi;
        }
        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
           
                string maTK = txtMaTK.Text;
                string tenDN = txtTenDN.Text;
                string tenNV = txtTenNV.Text;
                string diaChi = txtDiaChi.Text;
                QLTKBLL.Instance.UpdateTTTK(maTK, tenDN, tenNV, diaChi);
         }
    }
}
