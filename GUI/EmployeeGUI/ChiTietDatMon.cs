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
using System.Windows.Media.Media3D;

namespace DoAnPBL3.View
{
    public partial class ChiTietDatMon : Form
    {
        public ChiTietDatMon()
        {
            InitializeComponent();
            SetCBBBA();
            cbbMaBan.SelectedIndex = 0;
            SetCBBMA();
            cbbTenMA.SelectedIndex = 0;
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvCTDB.Rows.Count; i++)
            {
                dtgvCTDB.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCTDM.Controls.Add(form);
            this.pnlCTDM.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        public void ShowAllCTDB(string maPV,string ngayDat)
        {
            dtgvCTDB.AutoGenerateColumns = false;
            dtgvCTDB.DataSource = QLDatBanDatMon.Instance.GetAllCTBPV(maPV,ngayDat);
            SetSTT();
        }
        public void SetCBBBA()
        {
            cbbMaBan.Items.Add(new CBBItem { value = "0", text = "Tất cả" });
            string ngayDat = dtpkNgayDat.Value.Date.ToString("dd/MM/yyyy");
            List<CHITIETDATBAN> list = QLDatBanDatMon.Instance.GetCTDB("", ngayDat);
            if (list != null)
            {
                foreach(var bpv in list)
                {
                    cbbMaBan.Items.Add(new CBBItem { value = bpv.maPV, text = bpv.maBan });
                }    
            }
        }
        public void SetCBBMA()
        {
            foreach (MONAN ma in QLThucDon.Instance.GetAllMABy("Tất cả"))
            {
                cbbTenMA.Items.Add(new CBBItem { value = ma.maMA, text = ma.tenMA });
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maPV =((CBBItem)cbbMaBan.SelectedItem).value.ToString();
            string ngayDat = dtpkNgayDat.Value.ToString("dd/MM/yyyy");
            ShowAllCTDB(maPV, ngayDat);
            txtMaPV.Text = ((CBBItem)cbbMaBan.SelectedItem).value.ToString();
            QLDatBanDatMon.Instance.MaPV = txtMaPV.Text;
        }

        private void ChiTietDatBan_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void dtCTDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPV.Text = dtgvCTDB.SelectedRows[0].Cells["maPV"].Value.ToString();
            string maMA = dtgvCTDB.SelectedRows[0].Cells["maMA"].Value.ToString();
            QLThucDon.Instance.MaMA = maMA;
            foreach (dynamic item in cbbTenMA.Items)
            {
                if (item.value == maMA)
                {
                    cbbTenMA.SelectedItem = item;
                }
            }
            numSL.Value = Convert.ToInt32(dtgvCTDB.SelectedRows[0].Cells["soLuong"].Value);
            txtDG.Text = QLThucDon.Instance.GetMAByMaMA(((CBBItem)cbbTenMA.SelectedItem).value).giaMA.ToString("#,###");
            QLDatBanDatMon.Instance.MaPV = txtMaPV.Text;
        }

        private void cbbTenMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDG.Text = QLThucDon.Instance.GetMAByMaMA(((CBBItem)cbbTenMA.SelectedItem).value).giaMA.ToString("#,###");
        }

        private void btnXoaDat_Click(object sender, EventArgs e)
        {
            if (dtgvCTDB.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa món ăn đã đặt này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maPV = dtgvCTDB.SelectedRows[0].Cells["maPV"].Value.ToString();
                    string ngayDat = dtpkNgayDat.Value.ToString("dd/MM/yyyy");
                    QLDatBanDatMon.Instance.XoaDatMon(maPV, QLThucDon.Instance.MaMA);
                    ShowAllCTDB(((CBBItem)cbbMaBan.SelectedItem).value.ToString(), ngayDat);
                }
            }
            else
            {
                MessageBox.Show("Chọn món ăn đã đặt để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETBANPHUCVU ctpv = new CHITIETBANPHUCVU
                {
                    maPV = txtMaPV.Text,
                    maMA = ((CBBItem)cbbTenMA.SelectedItem).value.ToString(),
                    soLuong = Convert.ToInt32(numSL.Value),
                    giaMA = Convert.ToDouble(txtDG.Text)
                };
                QLDatBanDatMon.Instance.UpdateDatMon(ctpv);
                string ngayDat = dtpkNgayDat.Value.ToString("dd/MM/yyyy");
                ShowAllCTDB(((CBBItem)cbbMaBan.SelectedItem).value.ToString(), ngayDat);
                MessageBox.Show("Cập nhật thông tin đặt món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public double TongTien()
        {
            double s = 0;
            foreach(DataGridViewRow dr in dtgvCTDB.Rows)
            {
                string giama = dr.Cells["giaMA"].Value.ToString();
                s += Convert.ToDouble(Convert.ToInt32(dr.Cells["soLuong"].Value) * double.Parse(giama.Replace(" VNĐ", "").Replace(",", "")));
            }
            return s;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (QLDatBanDatMon.Instance.MaPV == null)
            {
                MessageBox.Show("Không có bàn nào hiện tại cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QLHoaDon.Instance.TongTien = TongTien();
                ShowFormInPanel(new QuanLyHoaDon());
            }
        }

        private void dtpkNgayDat_ValueChanged(object sender, EventArgs e)
        {
            if (cbbMaBan.Items != null)
                cbbMaBan.Items.Clear();
            SetCBBBA();
            cbbMaBan.SelectedIndex = 0;
        }
    }
}
