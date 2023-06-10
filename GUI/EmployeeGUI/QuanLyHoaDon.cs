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

    public partial class QuanLyHoaDon : Form
    {
        double tongHD;
        public QuanLyHoaDon()
        {
            InitializeComponent();
            ShowAllHD("");
            SetCBBNV();
        }
        public void ShowAllHD(string ngayTT)
        {
            dtgvDSHD.AutoGenerateColumns = false;
            dtgvDSHD.DataSource = QLHoaDon.Instance.GetAllHDBy(ngayTT);
            SetSTT();
        }
        public void SetCBBNV()
        {
            foreach (NHANVIEN nv in QLNhanVien.Instance.GetAll_NV(""))
            {
                cbbTenNV.Items.Add(new CBBItem { value = nv.maTK, text = nv.tenNV });
            }
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSHD.Rows.Count; i++)
            {
                dtgvDSHD.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlHoaDon.Controls.Add(form);
            this.pnlHoaDon.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            SetSTT();
            txtMaPV.Text = QLDatBanDatMon.Instance.MaPV;
            txtSDT.Text = QLKhachHang.Instance.SDT;
            foreach (var item in cbbTenNV.Items)
            {
                if (((CBBItem)item).value == QLTaiKhoan.Instance.GetUserByUserName().maTK)
                {
                    cbbTenNV.SelectedItem = item;
                }
            }
        }

        private void dtgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dtgvDSHD.SelectedRows[0].Cells["maHD"].Value.ToString();
            txtMaPV.Text = dtgvDSHD.SelectedRows[0].Cells["maPV"].Value.ToString();
            dtpkNgayLap.Value = Convert.ToDateTime(dtgvDSHD.SelectedRows[0].Cells["ngayThanhToan"].Value);
            txtTongTien.Text = Convert.ToDouble(dtgvDSHD.SelectedRows[0].Cells["tongTien"].Value).ToString("#,### VNĐ");
            string maTK = dtgvDSHD.SelectedRows[0].Cells["maTK"].Value.ToString();
            string maKH = dtgvDSHD.SelectedRows[0].Cells["maKH"].Value.ToString();
            txtSDT.Text = QLKhachHang.Instance.GetKHByMa(maKH).SDT;
            foreach (var item in cbbTenNV.Items)
            {
                if (((CBBItem)item).value == maTK)
                {
                    cbbTenNV.SelectedItem = item;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaPV.Text = "";

            cbbTenNV.SelectedIndex = -1;
            dtpkNgayLap.Value = DateTime.Now;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ngayTT = dtpkNgayTT.Value.ToString("dd/MM/yyyy");
            ShowAllHD(ngayTT);
        }

        public void SetDiemTichLuy()
        {
            if (QLHoaDon.Instance.TongTien >= 2000000)
            {
                QLKhachHang.Instance.SetDiemTichLuy();
            }
        }
        public void SetGiamGia()
        {
            KHACHHANG kh = QLKhachHang.Instance.GetKHByMa(QLKhachHang.Instance.MaKH);
            double giamGia = 0;
            if (0 < kh.diemTichLuy && kh.diemTichLuy % 3 == 0 && kh.coKM == false)
            {
                giamGia = QLHoaDon.Instance.TongTien * 20.0 / 100;
                tongHD = QLHoaDon.Instance.TongTien - giamGia;
                QLKhachHang.Instance.SetCoKM();
            }
            else
            {
                giamGia = 0;
                tongHD = QLHoaDon.Instance.TongTien;
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            QLKhachHang.Instance.SDT = sdt;
            if (txtMaHD.Text != "")
            {
                MessageBox.Show("Hóa đơn đã tồn tại. Không thể thêm mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (QLKhachHang.Instance.GetAllKHBy(sdt).Count == 0)
            {
                MessageBox.Show("Thêm khách hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowForminPanel(new View.KhachHang());
            }
            else
            {
                string maKH = QLKhachHang.Instance.GetAllKHBy(sdt)[0].maKH;
                QLKhachHang.Instance.MaKH = maKH;
                QLDatBanDatMon.Instance.AddMaKH(maKH);
                SetDiemTichLuy();
                SetGiamGia();
                QLHoaDon.Instance.TongTien = tongHD;
                txtTongTien.Text = tongHD.ToString("#,### VNĐ");
                HOADON hd = new HOADON
                {
                    maPV = txtMaPV.Text,
                    maTK = QLTaiKhoan.Instance.GetUserByUserName().maTK,
                    ngayThanhToan = DateTime.Now,
                    tongTien = QLHoaDon.Instance.TongTien
                };
                QLHoaDon.Instance.Add(hd);
                MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllHD("");
                QLDatBanDatMon.Instance.MaBan = QLDatBanDatMon.Instance.GetCTDB(QLDatBanDatMon.Instance.MaPV, "")[0].maBan;
                QLDatBanDatMon.Instance.HuyTrangThai();
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (dtgvDSHD.SelectedRows.Count != 1 || txtMaHD.Text == "" || txtMaPV.Text == "")
            {
                MessageBox.Show("Chọn một hóa đơn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QLHoaDon.Instance.MaHD = txtMaHD.Text;
                QLDatBanDatMon.Instance.MaPV = txtMaPV.Text;
                new InHoaDon().Show();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            ShowAllHD("");
        }
    }
}
