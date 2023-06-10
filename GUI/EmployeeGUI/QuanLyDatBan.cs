using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
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

namespace DoAnPBL3.View
{
    public partial class QuanLyDatBan : Form
    {

        public Guna2Button selectedTable;
        public QuanLyDatBan()
        {
            InitializeComponent();
        }

        public void LoadTable()
        {
            foreach (BANAN ba in QLBanAn.Instance.GetAllBABy("Tất cả", ""))
            {
                Guna2Button table = new Guna2Button();
                table.Text = "Bàn " + int.Parse(ba.maBan.Replace("MB", "")) + "\n" + ba.trangThai;
                table.ForeColor = Color.Black;
                table.TextAlign = HorizontalAlignment.Center;
                table.Tag = ba.maBan;
                table.Size = new Size(130, 115);
                table.FillColor = Color.White;
                table.Image = Image.FromFile("D:\\ẢNH PBL\\BanAn.png");
                table.ImageSize = new Size(40, 40);
                table.Click += new EventHandler(SelectedTable_Click);
                pnlDatBan.Controls.Add(table);
            }
        }
        private void SelectedTable_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            if (selectedTable == clickedButton)
            {
                return;
            }
            foreach (Control control in pnlDatBan.Controls)
            {
                selectedTable = clickedButton;
                QLDatBanDatMon.Instance.MaBan = clickedButton.Tag.ToString();
                txtBanDat.Text = clickedButton.Tag.ToString();
                if (control != clickedButton)
                {
                    ((Guna2Button)control).FillColor = SystemColors.Control;
                }
            }
            clickedButton.FillColor = Color.DarkSalmon;
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvTTDB.Rows.Count; i++)
            {
                dtgvTTDB.Rows[i - 1].Cells[0].Value = i;
            }
        }

        public void SetCBBMA(string tenLM)
        {
            foreach (MONAN monAn in QLThucDon.Instance.GetAllMABy(tenLM))
            {
                cbbTenMA.Items.Add(new CBBItem() { value = monAn.maMA, text = monAn.tenMA });
            }
        }
        public void SetCBBChuyenBan()
        {
            List<BANAN> list = new List<BANAN>();
            list = QLBanAn.Instance.GetAllBABy("Trống", "");
            foreach (BANAN banan in list)
            {
                cbbChuyenBan.Items.Add(new CBBItem() { value = banan.maBan, text = "Bàn " + int.Parse(banan.maBan.Replace("MB", "")) });
            }
        }
        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDB.Controls.Add(form);
            this.pnlDB.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        public void Click(string tenLM)
        {
            txtTenLM.Text = tenLM;
            cbbTenMA.Items.Clear();
            SetCBBMA(tenLM);
        }

        private void pbMonNuong_Click(object sender, EventArgs e)
        {
            Click("Món nướng");
        }

        private void pbMonHap_Click(object sender, EventArgs e)
        {
            Click("Món hấp");
        }

        private void pbMonLau_Click(object sender, EventArgs e)
        {
            Click("Món lẩu");
        }

        private void pbComMi_Click(object sender, EventArgs e)
        {
            Click("Cơm, mì");
        }

        private void pbNuocUong_Click(object sender, EventArgs e)
        {
            Click("Nước uống");
        }

        private void pbMonTM_Click(object sender, EventArgs e)
        {
            Click("Món tráng miệng");
        }
        public void SetTenMA()
        {
            foreach (DataGridViewRow dr in dtgvTTDB.Rows)
            {
                dr.Cells["tenMA"].Value = QLThucDon.Instance.GetMAByMaMA(dr.Cells["maMA"].Value.ToString()).tenMA;
            }
        }
        public void ShowTTDB(string maPV)
        {
            dtgvTTDB.AutoGenerateColumns = false;
            dtgvTTDB.DataSource = QLDatBanDatMon.Instance.GetAllCTBPV(maPV, "");
            SetTenMA();
            SetSTT();
        }
        private void btnDatMon_Click(object sender, EventArgs e)
        {
            string maBan = QLDatBanDatMon.Instance.MaBan;
            if (QLDatBanDatMon.Instance.MaPV == null || QLBanAn.Instance.GetBAByMaBan(maBan).trangThai == "Trống")
            {
                MessageBox.Show("Bạn chưa đặt bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtTenLM.Text == "" || cbbTenMA.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn món để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string maMA = ((CBBItem)cbbTenMA.SelectedItem).value;
                    CHITIETBANPHUCVU ctpv = new CHITIETBANPHUCVU()
                    {
                        maPV = QLDatBanDatMon.Instance.MaPV,
                        maMA = maMA,
                        giaMA = QLThucDon.Instance.GetMAByMaMA((maMA)).giaMA
                    };
                    bool Check = true;
                    if (dtgvTTDB.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow dr in dtgvTTDB.Rows)
                        {
                            if (dr.Cells["maMA"].Value.ToString() == maMA)
                            {
                                int soLuong = Convert.ToInt32(dr.Cells["soLuong"].Value) + (int)numSL.Value;
                                ctpv.soLuong = soLuong;
                                QLThucDon.Instance.MaMA = maMA;
                                QLDatBanDatMon.Instance.UpdateDatMon(ctpv);
                                Check = false;
                                break;
                            }
                        }
                    }
                    if (Check)
                    {
                        ctpv.soLuong = (int)numSL.Value;
                        QLDatBanDatMon.Instance.AddCTBanPhucVu(ctpv);
                    }
                    ShowTTDB(ctpv.maPV);
                    txtTenLM.Text = "";
                    cbbTenMA.SelectedIndex = -1;
                    numSL.Value = 0;
                }
            }
        }

        private void btnHuyDatMon_Click(object sender, EventArgs e)
        {
            if (dtgvTTDB.SelectedRows.Count < 1)
            {
                MessageBox.Show("Chọn món để xóa order", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> maDel = new List<string>();
                foreach (DataGridViewRow dr in dtgvTTDB.SelectedRows)
                {
                    maDel.Add(dr.Cells["maMA"].Value.ToString());
                }
                foreach (string del in maDel)
                {
                    QLDatBanDatMon.Instance.XoaDatMon(QLDatBanDatMon.Instance.MaPV, del);
                    ShowTTDB(QLDatBanDatMon.Instance.MaPV);
                }
            }

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (QLDatBanDatMon.Instance.MaBan == null)
            {
                MessageBox.Show("Chọn bàn ăn muốn chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbbChuyenBan.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn bàn ăn cần chuyển đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string maChuyen = ((CBBItem)cbbChuyenBan.SelectedItem).value;
                QLDatBanDatMon.Instance.ChuyenBan(maChuyen);
                pnlDatBan.Controls.Clear();
                LoadTable();
                cbbChuyenBan.Items.Clear();
                SetCBBChuyenBan();
                cbbChuyenBan.SelectedIndex = -1;
            }
        }

        private void DatBanKH_Load(object sender, EventArgs e)
        {
            SetCBBChuyenBan();
            LoadTable();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (QLBanAn.Instance.GetBAByMaBan(QLDatBanDatMon.Instance.MaBan).trangThai == "Đã đặt")
            {
                MessageBox.Show("Bàn này đang được đặt.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BANPHUCVU banPV = new BANPHUCVU()
                {
                    maKH = QLKhachHang.Instance.MaKH,
                    maTK = QLTaiKhoan.Instance.GetUserByUserName().maTK,
                    thoiGianVao = DateTime.Now,
                };
                txtGioVao.Text = banPV.thoiGianVao.ToString("dd/MM/yyyy   hh:mm:ss");
                QLDatBanDatMon.Instance.AddBanPhucVu(banPV);
                CHITIETDATBAN CTDB = new CHITIETDATBAN()
                {
                    maBan = QLDatBanDatMon.Instance.MaBan,
                    maPV = QLDatBanDatMon.Instance.MaPV
                };
                QLDatBanDatMon.Instance.AddCTDatBan(CTDB);

                BANAN ba = QLDatBanDatMon.Instance.SetTrangThaiBA();
                selectedTable.Text = "Bàn " + int.Parse(ba.maBan.Replace("MB", "")) + "\n" + ba.trangThai;
                if (cbbChuyenBan.Items != null)
                {
                    cbbChuyenBan.Items.Clear();
                }
                SetCBBChuyenBan();
            }
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if (QLDatBanDatMon.Instance.MaPV == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để hủy đặt!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information); return;
            }
            else
            {
                QLDatBanDatMon.Instance.XoaBanDaDat();
                BANAN ba = QLDatBanDatMon.Instance.HuyTrangThai();
                selectedTable.Text = "Bàn " + int.Parse(ba.maBan.Replace("MB", "")) + "\n" + ba.trangThai;
                if (cbbChuyenBan.Items != null)
                {
                    cbbChuyenBan.Items.Clear();
                }
                SetCBBChuyenBan();
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ChiTietDatMon());
        }


    }
}
