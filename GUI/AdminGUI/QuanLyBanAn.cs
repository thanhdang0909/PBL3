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
    public partial class QuanLyBanAn : Form
    {
        public QuanLyBanAn()
        {
            InitializeComponent();
            SetCBB();
            cbbTrangThai.SelectedIndex = 0;
            ShowAllBABy("Tất cả");
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

        public void ShowAllBABy(string TT, string soGhe = "")
        {
            dtgvBanan.AutoGenerateColumns = false;
            dtgvBanan.DataSource = QLBanAn.Instance.GetAllBABy(TT, soGhe);
            SetSTT();
        }
        public void SetCBB()
        {
            cbbTrangThai.Items.Add("Tất cả");
            List<string> trangThai = new List<string>();
            foreach (var TT in QLBanAn.Instance.GetAllBABy("Tất cả", ""))
            {
                trangThai.Add(TT.trangThai);
            }
            trangThai = trangThai.Distinct().ToList();
            foreach (string TT in trangThai)
            {
                cbbTrangThai.Items.Add(TT);
            }
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvBanan.Rows.Count; i++)
            {
                dtgvBanan.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void BanAnAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemlichsudatban_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new LichSuDatBan());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string trangThai = cbbTrangThai.SelectedItem.ToString();
            ShowAllBABy(trangThai);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cbbTrangThai.SelectedIndex = 2;
                BANAN ba = new BANAN()
                {
                    soGhe = Convert.ToInt32(txtSoghe.Text),
                    trangThai = cbbTrangThai.SelectedItem.ToString(),
                    ghiChu = txtGhichu.Text,
                    coXoa = false
                };
                QLBanAn.Instance.Add(ba);
                ShowAllBABy("Tất cả");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgvBanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaban.Text = dtgvBanan.SelectedRows[0].Cells["maBan"].Value.ToString();
            txtSoghe.Text = dtgvBanan.SelectedRows[0].Cells["soGhe"].Value.ToString();
            cbbTrangThai.SelectedIndex = cbbTrangThai.Items.IndexOf(dtgvBanan.SelectedRows[0].Cells["trangThai"].Value.ToString());
            txtGhichu.Text = dtgvBanan.SelectedRows[0].Cells["ghiChu"].Value.ToString();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBanan.SelectedRows.Count == 1)
                {
                    BANAN ba = new BANAN()
                    {
                        maBan = txtMaban.Text,
                        soGhe = Convert.ToInt32(txtSoghe.Text),
                        trangThai = cbbTrangThai.SelectedItem.ToString(),
                        ghiChu = txtGhichu.Text
                    };
                    QLBanAn.Instance.Update(ba);
                    ShowAllBABy("Tất cả");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một bàn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimkiem.Text = cbbTrangThai.SelectedItem.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa bàn ăn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                List<string> MBDel = new List<string>();
                foreach (DataGridViewRow dr in dtgvBanan.SelectedRows)
                {
                    MBDel.Add(dr.Cells["maBan"].Value.ToString());
                }
                foreach (string MB in MBDel)
                {
                    QLBanAn.Instance.Delete(MB);
                }
                ShowAllBABy("Tất cả");
            }
        }
    }
}
