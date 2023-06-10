using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using DoAnPBL3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace DoAnPBL3.View
{
    public partial class CaLamViec : Form
    {
        public CaLamViec()
        {
            InitializeComponent();
            ShowAllCT("");
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvCalamviec.Rows.Count; i++)
            {
                dtgvCalamviec.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowAllCT(string date)
        {
            dtgvCalamviec.AutoGenerateColumns = false;
            dtgvCalamviec.DataSource = QLCaLamBLL.Instance.GetAllCaLam(date); ;
            SetSTT();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCalamviec.Controls.Add(form);
            this.pnlCalamviec.Controls.SetChildIndex(form, 0);
            form.Show();
        }



        private void btDangKy_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DangKyCaLam());
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            string ngaylam = dtmNgaylam.Value.ToString("dd/MM/yyyy");
            ShowAllCT(ngaylam);
        }

        private void CaLamViec_Load_1(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new LuongNhanVien());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

