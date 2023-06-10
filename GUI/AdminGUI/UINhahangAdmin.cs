using System;
using DoAnPBL3.View;
using Guna.UI2.WinForms;
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
    public partial class UINhahangAdmin : Form
    {

        public UINhahangAdmin()
        {
            InitializeComponent();
            ShowForminPanel(new UI());
            pnlUI.Hide();

        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDeskTop.Controls.Add(form);
            this.pnlDeskTop.Controls.SetChildIndex(form, 0);
            form.Show();
        }


        public void ShowPanel(Guna2Button btn)
        {
            pnlUI.Height = btn.Height;
            pnlUI.Top = btn.Top;
            pnlUI.Show();
        }

        // Quản lý
        private void btnQuanly_MouseEnter(object sender, EventArgs e)
        {
            ShowPanel(btnQuanly);
            ((Guna2Button)sender).ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void contextMenuStrip2_MouseLeave(object sender, EventArgs e)
        {
            ((ContextMenuStrip)sender).Hide();
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyNhanVien());
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new KhachHang());
        }
        private void quảnLýCaTrựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyCaLam());
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyTaiKhoan());
        }


        //Thống kê
        private void btnThongke_MouseEnter(object sender, EventArgs e)
        {
            ShowPanel(btnThongke);
            ((Guna2Button)sender).ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void contextMenuStrip3_MouseLeave(object sender, EventArgs e)
        {
            ((ContextMenuStrip)sender).Hide();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongKeDoanhThu());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongKeKhachHang());
        }


        private void btnBanan_Click(object sender, EventArgs e)
        {
            ShowPanel(btnBanan);
            ShowForminPanel(new QuanLyBanAn());
        }
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ShowPanel(btnHoadon);
            ShowForminPanel(new HoaDon());
        }


        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            ShowPanel(btnTrangchu);
            ShowForminPanel(new TrangChuAdmin());

        }

        private void btnThucdon_Click(object sender, EventArgs e)
        {
            ShowPanel(btnThucdon);
            ShowForminPanel(new QuanLyThucDon());
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            ShowPanel(btnQuanly);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ShowPanel(btnThongke);
        }

        private void quảnLýLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyLuong());
        }
    }
}
