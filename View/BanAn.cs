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
            dtgvDSBA.DataSource = QLBABLL.Instance.GetAllBABy("Tất cả", "");
            SetCBB();
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
            cbbTrangThai.Items.Add("Đã đặt");
            cbbTrangThai.Items.Add("Trống");
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

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DatBanKH());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string trangThai =cbbTrangThai.SelectedItem.ToString();
            string soGhe = txtSoGhe.Text;
            dtgvDSBA.DataSource = QLBABLL.Instance.GetAllBABy(trangThai, soGhe);
        }

       
    }
}
