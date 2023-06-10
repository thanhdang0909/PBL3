using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtSDT.Text = QLKhachHang.Instance.SDT;
        }

        public void ShowAllKHBy(string sdt)
        {
            dtgvDSKH.AutoGenerateColumns = false;
            dtgvDSKH.DataSource = QLKhachHang.Instance.GetAllKHBy(sdt);
            SetSTT();
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSKH.Rows.Count; i++)
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
            QLKhachHang.Instance.MaKH = dtgvDSKH.SelectedRows[0].Cells["maKH"].Value.ToString();
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
            string phonePattern = @"\d{10}";
            Match matchSDT = Regex.Match(txtSDT.Text, phonePattern);
            if (matchSDT.Success == false)
            {
                MessageBox.Show("Sai định dạng số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenKH.Text == "" || rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KHACHHANG kh = new KHACHHANG
                {
                    tenKH = txtTenKH.Text,
                    gioiTinh = rdoNam.Checked,
                    diaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    diemTichLuy = 0,
                    coKM = false
                };
                QLKhachHang.Instance.Add(kh);
                ShowAllKHBy("");
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string phonePattern = @"\d{10}";
            Match matchSDT = Regex.Match(txtSDT.Text, phonePattern);
            if (matchSDT.Success == false)
            {
                MessageBox.Show("Sai định dạng số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenKH.Text == "" || rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dtgvDSKH.SelectedRows.Count == 1)
                {
                    KHACHHANG kh = new KHACHHANG
                    {
                        maKH = txtMaKH.Text,
                        tenKH = txtTenKH.Text,
                        gioiTinh = rdoNam.Checked,
                        diaChi = txtDiaChi.Text,
                        SDT = txtSDT.Text
                    };
                    QLKhachHang.Instance.Update(kh);
                    ShowAllKHBy("");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtDiemTL.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (QLDatBanDatMon.Instance.MaPV == "")
                MessageBox.Show("Không có hóa đơn cần thanh toán cho khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ShowForminPanel(new QuanLyHoaDon());
            }
        }
    }
}
