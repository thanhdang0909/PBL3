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

namespace DoAnPBL3.View
{
    public partial class KhachHang : Form
    {
        
        public KhachHang()
        {
            InitializeComponent();
            ShowAllKHBy("");
        }
        
        public void ShowAllKHBy(string sdt)
        {
            dtgvDSKH.DataSource = QLKHBLL.Instance.GetAllKHBy(sdt);
            SetSTT();
        }
        public void SetSTT()
        {
            for(int i = 1; i <= dtgvDSKH.Rows.Count; i++)
            {
                dtgvDSKH.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlKhachHang.Controls.Add(form);
            this.pnlKhachHang.Controls.SetChildIndex(form, 0);
            form.Show();
        }
    
        private void KhachHang_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = txtTimKiem.Text;
            ShowAllKHBy(sdt);
        }
        private void dtgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvDSKH.SelectedRows[0].Cells["maKH"].Value.ToString();
            txtTenKH.Text = dtgvDSKH.SelectedRows[0].Cells["tenKH"].Value.ToString();
            txtSDT.Text = dtgvDSKH.SelectedRows[0].Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvDSKH.SelectedRows[0].Cells["diaChi"].Value.ToString();
            txtDiemTL.Text = dtgvDSKH.SelectedRows[0].Cells["diemTichLuy"].Value.ToString();
            if (Convert.ToBoolean(dtgvDSKH.SelectedRows[0].Cells["gioiTinh"].Value))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            } 
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG
            {
                tenKH = txtTenKH.Text, gioiTinh = rdoNam.Checked, diaChi = txtDiaChi.Text, SDT = txtSDT.Text,diemTichLuy = 0
            };
            QLKHBLL.Instance.Add(kh);
            ShowAllKHBy("");
        }

       
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(dtgvDSKH.SelectedRows.Count == 1)
            {
                KHACHHANG kh = new KHACHHANG
                {
                    maKH = txtMaKH.Text,
                    tenKH = txtTenKH.Text,
                    gioiTinh = rdoNam.Checked,
                    diaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text
                };
                QLKHBLL.Instance.Update(kh);
                ShowAllKHBy("");
            } 
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để cập nhật!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private void btnDatBan_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DatBan());
        }

    }
}
