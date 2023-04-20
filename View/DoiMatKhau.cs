using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtTendangnhap.Text = QLTKBLL.Instance.Tendangnhap;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMatkhaucu.PasswordChar == '*')
            {
                txtMatkhaucu.PasswordChar = '\0';
            }
            else
            {
                txtMatkhaucu.PasswordChar = '*';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtNhaplaimatkhau.PasswordChar == '*')
            {
                txtNhaplaimatkhau.PasswordChar = '\0';
            }
            else
            {
                txtNhaplaimatkhau.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtMatkhaumoi.PasswordChar == '*')
            {
                txtMatkhaumoi.PasswordChar = '\0';
            }
            else
            {
                txtMatkhaumoi.PasswordChar = '*';
            }
        }

        

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtMatkhaucu.Text;
            string matkhaumoi = txtMatkhaumoi.Text;
            string xacnhanmatkhau = txtNhaplaimatkhau.Text;
            QLTKBLL.Instance.Doimatkhau(matkhaucu, matkhaumoi, xacnhanmatkhau);

        }
    }
}
