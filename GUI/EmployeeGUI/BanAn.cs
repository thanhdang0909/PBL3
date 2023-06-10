using DoAnPBL3.BLL;
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
    public partial class BanAn : Form
    {
        
        public BanAn()
        {
            InitializeComponent();
            ShowAllBA("Tất cả", "");
            SetCBB();
            cbbTrangThai.SelectedIndex = 0;
        }
        public void ShowAllBA(string trangthai, string soluong)
        {
            dtgvDSBA.AutoGenerateColumns = false;
            dtgvDSBA.DataSource = QLBanAn.Instance.GetAllBABy(trangthai,soluong);
            SetSTT();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlBanAn.Controls.Add(form);
            this.pnlBanAn.Controls.SetChildIndex(form, 0);
            form.Show();
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
            for (int i = 1; i <= dtgvDSBA.Rows.Count; i++)
            {
                dtgvDSBA.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void BanAn_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string trangThai =cbbTrangThai.SelectedItem.ToString();
            string soGhe = txtSoGhe.Text;
            ShowAllBA(trangThai, soGhe);
        }

        private void btnCTBA_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyDatBan());
        }

        private void btChiTietDatBan_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietDatMon());
        }
    }
}
