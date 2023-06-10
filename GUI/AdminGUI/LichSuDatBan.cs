using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
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
    public partial class LichSuDatBan : Form
    {
        public LichSuDatBan()
        {
            InitializeComponent();
            ShowAllLSDB("0");
            SetCBB();
            cbbTKHD.SelectedIndex = 0;
        }

        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill; 
            this.pnlLSDB.Controls.Add(form);
            this.pnlLSDB.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        public void ShowAllLSDB(string maTK)
        {
            dtgvLSDB.AutoGenerateColumns = false;
            dtgvLSDB.DataSource = QLDatBanDatMon.Instance.GetLSDBByMaTK(maTK);
            SetSTT();
            SetTenKH();
            SetTenNV();
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvLSDB.Rows.Count; i++)
            {
                dtgvLSDB.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void SetCBB()
        {
            cbbTKHD.Items.Add(new CBBItem { value = "0", text = "Tất cả" });
            foreach (NHANVIEN nv in QLNhanVien.Instance.GetAll_NV(""))
            {
                cbbTKHD.Items.Add(new CBBItem { value = nv.maTK, text = nv.tenNV });
            }
        }
        public void SetTenNV()
        {
            foreach(DataGridViewRow dr in dtgvLSDB.Rows)
            {
                dr.Cells["tenNV"].Value = QLNhanVien.Instance.GetNVByMaTK(dr.Cells["maTK"].Value.ToString()).tenNV;
            }
        }
        public void SetTenKH()
        {
            foreach (DataGridViewRow dr in dtgvLSDB.Rows)
            {
                dr.Cells["tenKH"].Value = QLKhachHang.Instance.GetKHByMa(dr.Cells["maKH"].Value.ToString()).tenKH;
            }
        }
        private void XemLichSuDatBanAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
            SetTenNV();
            SetTenKH();
        }

        private void btnCTDB_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ChiTietDatMon());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maTK = ((CBBItem)cbbTKHD.SelectedItem).value;
            ShowAllLSDB(maTK);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
