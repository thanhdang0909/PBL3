using Guna.UI2.WinForms;
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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SetPassW(Guna2TextBox txt)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
            }
            else
            {
                txt.PasswordChar = '*';
            }
        }
        private void picturebox1_Click(object sender, EventArgs e)
        {
            SetPassW(txtMK1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetPassW(txtMK2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            SetPassW(txtMK3);
        }
    }
}
