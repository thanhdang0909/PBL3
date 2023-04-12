using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
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
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Cho panel lên trên cùng
            pnlTrangChuAdmin.Controls.Add(form);
            pnlTrangChuAdmin.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DoiMatKhau());
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongTinTaiKhoanAdmin());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
