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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
            ShowBill();
        }

        public void ShowBill()
        {
            string maTK = "", maKH = "";
            List<object> hoadon = QLHoaDon.Instance.GetHDByMaHD(QLHoaDon.Instance.MaHD);
            foreach (dynamic item in hoadon)
            {
                maTK = item.maTK;
                maKH = item.maKH;
                txtNgayTT.Text = item.ngayThanhToan.ToString("dd-MM-yyyy  hh:mm:ss");
            }
            txtMaHD.Text = QLHoaDon.Instance.MaHD;
            txtTenNV.Text = QLNhanVien.Instance.GetNVByMaTK(maTK).tenNV;
            txtTenKH.Text = QLKhachHang.Instance.GetKHByMa(maKH).tenKH;
            dtgvDSHD.AutoGenerateColumns = false;
            dtgvDSHD.DataSource = QLDatBanDatMon.Instance.GetAllCTDB(QLDatBanDatMon.Instance.MaPV);
            SetSTT();
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSHD.Rows.Count; i++)
            {
                dtgvDSHD.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ThanhTien()
        {
            foreach (DataGridViewRow dr in dtgvDSHD.Rows)
            {
                string giama = dr.Cells["giaMA"].Value.ToString();
                dr.Cells["TT"].Value = (Convert.ToInt32(dr.Cells["soLuong"].Value) * double.Parse(giama.Replace(" VNĐ", "").Replace(",", ""))).ToString("#,### VNĐ");
            }
        }

        public double TongTien()
        {
            double s = 0;
            foreach (DataGridViewRow dr in dtgvDSHD.Rows)
            {
                string thanhTienStr = dr.Cells["TT"].Value.ToString();
                double thanhTien = double.Parse(thanhTienStr.Replace(" VNĐ", "").Replace(",", ""));
                s += thanhTien;
            }
            return s;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            SetSTT();
            ThanhTien();
            foreach (dynamic hd in QLHoaDon.Instance.GetHDByMaHD(QLHoaDon.Instance.MaHD))
            {
                double giamGia = TongTien() - hd.tongTien;
                if (giamGia == 0)
                {
                    txtGiamGia.Text = "0 VNĐ";
                }
                else
                {
                    txtGiamGia.Text = giamGia.ToString("#,### VNĐ");
                }
                txtTongTien.Text = hd.tongTien.ToString("#,### VNĐ");
                break;
            }
        }
    }
}
