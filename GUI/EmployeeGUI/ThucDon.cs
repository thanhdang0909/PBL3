using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            cbbTimKiem.Items.Add(new CBBItem { value = "0", text = "Tất cả" });
           foreach(LOAIMON LM in QLThucDon.Instance.GetAllLMA())
            {
                cbbTimKiem.Items.Add(new CBBItem { value = LM.maLM,text = LM.tenLM});
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
            dtgvDSMA.AutoGenerateColumns = false;
            List<Image> list = new List<Image>();
            dtgvDSMA.DataSource = QLThucDon.Instance.GetAllMABy(tenLM);
            foreach(MONAN ma in QLThucDon.Instance.GetAllMABy(tenLM))
            {
                Image image = Convert_Image.ConvertImage(ma.anhMA);
                list.Add(image);
            }
            int i = 0;
            foreach (DataGridViewRow dr in dtgvDSMA.Rows)
            {
                dr.Cells["anhMA"].Value = list[i];
                i++;
            }
            SetSTT();
        }



        private void btnTK_Click(object sender, EventArgs e)
        {
            string tenLM = ((CBBItem)cbbTimKiem.SelectedItem).text;
            ShowAllMABy(tenLM) ;
        }

        public void Click(string tenLM)
        {
            foreach(var item in cbbTimKiem.Items)
            {
                if(((CBBItem)item).text == tenLM)
                {
                    cbbTimKiem.SelectedItem = item;
                }    
            }
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
