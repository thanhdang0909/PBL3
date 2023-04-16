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
    public partial class TrangMieng : Form
    {
        public TrangMieng()
        {
            InitializeComponent();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlTrangMieng.Controls.Add(form);
            this.pnlTrangMieng.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void btnCTDatMon_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietDatMon());
        }

    }
}
