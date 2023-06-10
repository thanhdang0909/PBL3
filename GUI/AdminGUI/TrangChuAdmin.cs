using System;
using DoAnPBL3.View;
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
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }


        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlTrangChuAdmin.Controls.Add(form);
            this.pnlTrangChuAdmin.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DoiMatKhau());
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongTinTaiKhoan());
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
