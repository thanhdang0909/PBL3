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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCTHoaDon.Controls.Add(form);
            this.pnlCTHoaDon.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new InHoaDon());
        }
    }
}
