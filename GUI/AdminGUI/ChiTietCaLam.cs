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
    public partial class ChiTietCaLam : Form
    {
        public ChiTietCaLam()
        {
            InitializeComponent();
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvChiTiet.Rows.Count; i++)
            {
                dtgvChiTiet.Rows[i - 1].Cells[0].Value = i;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string date = dtpkThangNam.Value.ToString("MM/yyyy");
            dtgvChiTiet.AutoGenerateColumns = false;
            dtgvChiTiet.DataSource = QLCaLamBLL.Instance.GetCaLamPC(date,null);
            SetSTT();
        }

        private void ChiTietCaLamNV_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
