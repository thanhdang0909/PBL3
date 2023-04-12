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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            
            new UINhaHang().ShowDialog();
            this.Close();
        }
    }
}
