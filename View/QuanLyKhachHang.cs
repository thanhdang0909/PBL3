using System;
using DoAnPBL3.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.BLL;
using DoAnPBL3.DTO;

namespace DoAnPBL3
{
  
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
            ShowAllKHBy("");
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlBanan.Controls.Add(form);
            pnlBanan.Controls.SetChildIndex(form, 0);
            form.Show();
        }
      
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvKhachhang.Rows.Count; i++)
            {
                dtgvKhachhang.Rows[i - 1].Cells[0].Value = i;
            }
        }
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            SetSTT();
        }
        public void ShowAllKHBy(string sdt)
        {
            dtgvKhachhang.DataSource = QLKHBLL.Instance.GetAllKHBy(sdt);
            SetSTT();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemlichsudatban_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new XemLichSuDatBanAdmin());
        }

        private void dtgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakhachhang.Text = dtgvKhachhang.SelectedRows[0].Cells["maKH"].Value.ToString();
            txtTenkhachhang.Text = dtgvKhachhang.SelectedRows[0].Cells["tenKH"].Value.ToString();
            txtSDT.Text = dtgvKhachhang.SelectedRows[0].Cells["SDT"].Value.ToString();
            txtDiachi.Text = dtgvKhachhang.SelectedRows[0].Cells["diaChi"].Value.ToString();
            txtDiemTL.Text = dtgvKhachhang.SelectedRows[0].Cells["diemTichLuy"].Value.ToString();
            if (Convert.ToBoolean(dtgvKhachhang.SelectedRows[0].Cells["gioiTinh"].Value))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sdt = txtTimkiem.Text;
            ShowAllKHBy(sdt);
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dtgvKhachhang.SelectedRows.Count == 1)
            {
                KHACHHANG kh = new KHACHHANG
                {
                    maKH = txtMakhachhang.Text,
                    tenKH = txtTenkhachhang.Text,
                    gioiTinh = rdoNam.Checked,
                    diaChi = txtDiachi.Text,
                    SDT = txtSDT.Text,
                };
                QLKHBLL.Instance.Update(kh);
                ShowAllKHBy("");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
