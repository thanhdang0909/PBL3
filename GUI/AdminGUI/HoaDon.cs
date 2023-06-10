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
using DoAnPBL3.DTO;
using DoAnPBL3.BLL;

namespace DoAnPBL3
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            SetCBB();
            cbbTenNV.SelectedIndex = 0;
            ShowAllHDBy("0");
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSHD.Rows.Count; i++)
            {
                dtgvDSHD.Rows[i - 1].Cells[0].Value = i;
            }
        }

        public void SetCBB()
        {
            cbbTenNV.Items.Add(new CBBItem { value = "0",text = "Tất cả"});
            foreach(NHANVIEN nv in QLNhanVien.Instance.GetAll_NV(""))
            {
                cbbTenNV.Items.Add(new CBBItem { value = nv.TAIKHOAN.maTK, text = nv.tenNV });
            }    
        }
        public void ShowAllHDBy(string maTK)
        {
            dtgvDSHD.AutoGenerateColumns = false;
            dtgvDSHD.DataSource = QLHoaDon.Instance.GetAllHDByMaTK(maTK);
            SetTenNV();
            SetTenKH();
            SetSTT();
        }    
        public void SetTenNV()
        {
            foreach(DataGridViewRow dr in dtgvDSHD.Rows)
            {
                string maTK = dr.Cells["Column2"].Value.ToString();
                dr.Cells["tenNV"].Value = QLNhanVien.Instance.GetNVByMaTK(maTK).tenNV;
            }
        }
        public void SetTenKH()
        {
            foreach (DataGridViewRow dr in dtgvDSHD.Rows)
            {
                string maKH = dr.Cells["maKH"].Value.ToString();
                dr.Cells["tenKH"].Value = QLKhachHang.Instance.GetKHByMa(maKH).tenKH;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlHoadon.Controls.Add(form);
            pnlHoadon.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnXemchitiethoadon_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietHoaDon());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maTK = ((CBBItem)cbbTenNV.SelectedItem).value.ToString();
            ShowAllHDBy(maTK) ;
        }

        private void HoaDonAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
            SetTenNV();
            SetTenKH();
        }
    }
}
