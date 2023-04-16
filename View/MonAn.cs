using DoAnPBL3.View;
using System;
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
    public partial class MonAn : Form
    {
        public MonAn()
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
            form.Dock = DockStyle.Fill;
            this.pnlMonAn.Controls.Add(form);
            this.pnlMonAn.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnCTDatMon_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietDatMon());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
