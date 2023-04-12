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
   
    public partial class HoaDon : Form
    {
       
        public HoaDon()
        {
            InitializeComponent();
        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlHoaDon.Controls.Add(form);
            this.pnlHoaDon.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnCTHoaDon_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new ChiTietHoaDon());
        }
    }
}
