using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            NHANVIEN nv = QLTaiKhoan.Instance.GetUserByUserName();
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
            string phonePattern = @"\d{10}";
            Match match = Regex.Match(tendangnhap, phonePattern);
            if (match.Success == false)
            {
                MessageBox.Show("Sai định dạng tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tendangnhap == "" || tennguoidung == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                QLTaiKhoan.Instance.UpdateInfoAccount(matk, tendangnhap, tennguoidung, diachi);
                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
