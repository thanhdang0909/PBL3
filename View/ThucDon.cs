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
    public partial class ThucDon : Form
    {
        public ThucDon()
        {
            InitializeComponent();
            SetCBB();
            ShowAllMABy("Tất cả");
        }

        public void SetCBB()
        {
            cbbTimKiem.Items.Add("Tất cả");
           foreach(string LM in QLTDBLL.Instance.GetAllTLM())
            {
                cbbTimKiem.Items.Add(LM);
            }    
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSMA.Rows.Count; i++)
            {
                dtgvDSMA.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            cbbTimKiem.SelectedIndex = 0;
            SetSTT();
        }

        public void ShowAllMABy(string tenLM)
        {
            dtgvDSMA.DataSource = QLTDBLL.Instance.GetAllMABy(tenLM);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tenLM = cbbTimKiem.SelectedItem.ToString();
            ShowAllMABy(tenLM) ;
        }

        public void Click(string tenLM)
        {
            cbbTimKiem.SelectedIndex = cbbTimKiem.Items.IndexOf(tenLM);
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
    }
}
