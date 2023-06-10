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
    public partial class TrangChuNhanVien : Form
    {
        public TrangChuNhanVien()
        {
            InitializeComponent();
        }


        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlTrangChu.Controls.Add(form);
            this.pnlTrangChu.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongTinTaiKhoan());
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DoiMatKhau());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();
                }
            new DangNhap().Show();
         }
    }
}
