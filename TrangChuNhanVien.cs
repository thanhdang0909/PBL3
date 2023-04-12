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
    public partial class TrangChuNhanVien : Form
    {
        public TrangChuNhanVien()
        {
            InitializeComponent();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            new ThucDon().ShowDialog();
        }
    }
}
