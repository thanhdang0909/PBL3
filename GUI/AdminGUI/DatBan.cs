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
    public partial class DatBan : Form
    {

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDatBan.Controls.Add(form);
            this.pnlDatBan.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        public DatBan()
        {
            InitializeComponent();
        }
        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            //ShowForminPanel(new MonAn());
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChuyenBan());
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new GopBan()); ;
        }

        private void btnCTDatBan_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new ChiTietDatBan()); 
        }
    }
}
