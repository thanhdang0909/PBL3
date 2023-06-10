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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
            ShowAllCTHD("0");
            SetCBB();
            cbbMaHD.SelectedIndex = 0;
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvChitiethoadon.Rows.Count; i++)
            {
                dtgvChitiethoadon.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void SetCBB()
        {
            cbbMaHD.Items.Add(new CBBItem { value = "0", text = "Tất cả"});
            foreach(dynamic HD in QLHoaDon.Instance.GetAllHDBy(""))
            {
                cbbMaHD.Items.Add(new CBBItem { value = HD.maPV, text = HD.maHD});
            }    
        }
        public void ShowAllCTHD(string maPV)
        {
            dtgvChitiethoadon.AutoGenerateColumns = false;
            if(maPV == "0")
            {
                dtgvChitiethoadon.DataSource = QLDatBanDatMon.Instance.GetAllCTDB("");
                ThanhTien();
            }    
            else
            {
                dtgvChitiethoadon.DataSource = QLDatBanDatMon.Instance.GetAllCTDB(maPV);
                ThanhTien();
            }    
            SetSTT();
        }
        public void ThanhTien()
        {
            foreach (DataGridViewRow dr in dtgvChitiethoadon.Rows)
            {
                dr.Cells["TT"].Value = (Convert.ToInt32(dr.Cells["soLuong"].Value) * Convert.ToDouble(dr.Cells["giaMA"].Value)).ToString("#,### VNĐ");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChiTietHoaDonAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
            ThanhTien();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maPV = ((CBBItem)cbbMaHD.SelectedItem).value;
            ShowAllCTHD(maPV);
        }
    }
}
