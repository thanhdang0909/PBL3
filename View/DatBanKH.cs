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
    public partial class DatBanKH : Form
    {
        public DatBanKH()
        {
            InitializeComponent();
        }


        private void btnInHD_Click(object sender, EventArgs e)
        {
            new InHoaDon().ShowDialog();
        }
    }
}
