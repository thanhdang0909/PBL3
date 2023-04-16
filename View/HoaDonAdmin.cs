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
    public partial class HoaDonAdmin : Form
    {
        public HoaDonAdmin()
        {
            InitializeComponent();
        }
     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Cho panel lên trên cùng
            pnlHoadon.Controls.Add(form);
            pnlHoadon.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnXemchitiethoadon_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietHoaDonAdmin());
        }
    }
}
