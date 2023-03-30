using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class NhomMonAn : Form
    {
        public NhomMonAn()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            txt_TL.Text = "";
            cbb_ML.SelectedIndex = -1;
        }
    }
}
