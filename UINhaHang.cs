using DoAnPBL3.View;
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

namespace DoAnPBL3
{
    public partial class UINhaHang : Form
    {
       
        public UINhaHang()
        {
            InitializeComponent();
            ShowForminPanel(new UI());
        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDeskTop.Controls.Add(form);
            this.pnlDeskTop.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            ((ContextMenuStrip)sender).Hide();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new MonAn());
        }

        private void nướcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new NuocUong());
        }

        private void trángMiệngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new TrangMieng());
        }
        private void btnThucDon_MouseEnter(object sender, EventArgs e)
        {

            ((Guna2Button)sender).ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

     
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new TrangChuNV());
        }
        private void btnBanAn_Click(object sender, EventArgs e)
        {
           
            ShowForminPanel(new BanAn());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new HoaDon());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new KhachHang());
        }

        private void btnCaLV_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new CaLamViec());
        }

     
    }
}
