using System;
using DoAnPBL3.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.BLL;
using System.Net.NetworkInformation;

namespace DoAnPBL3
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            SetCbbVaitro();
        }
        public void SetCbbVaitro()
        {
            cbbVaitro.Items.AddRange(new object[]
            {
                "All","1","0"
            });
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            string cbb = cbbVaitro.SelectedItem != null ? cbbVaitro.SelectedItem.ToString() : "";
            dtgvQLTK.DataSource = QLTKBLL.Instance.GetAll_TaiKhoan(txt, cbb);
        }

        private void dtgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvQLTK.SelectedRows.Count > 0)
            {
                txtMaTK.Text = dtgvQLTK.SelectedRows[0].Cells["maTK"].Value.ToString();
                txtTendangnhap.Text = dtgvQLTK.SelectedRows[0].Cells["tenDangNhap"].Value.ToString();
                txtMathau.Text = dtgvQLTK.SelectedRows[0].Cells["matKhau"].Value.ToString();
                cbbVaitro.Text = Convert.ToInt32(dtgvQLTK.SelectedRows[0].Cells["vaiTro"].FormattedValue).ToString();
            }
        }

        
    }
}
