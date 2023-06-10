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
    public partial class QuanLyLuong : Form
    {
        public QuanLyLuong()
        {
            InitializeComponent();
            SetCBB();
            cbbNV.SelectedIndex = 0;
        }
        public void SetDTGV()
        {
            if (dtgvLuongNV.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dtgvLuongNV.Rows)
                {
                    string maTK = dr.Cells["maTK"].Value.ToString();
                    dr.Cells["tenNV"].Value = QLNhanVien.Instance.GetNVByMaTK(maTK).tenNV;
                    dr.Cells["luongTheoGio"].Value = QLNhanVien.Instance.GetNVByMaTK(maTK).luongTheoGio;
                    dr.Cells["tienLuong"].Value = Convert.ToInt32(dr.Cells["tongGioLam"].Value) * QLNhanVien.Instance.GetNVByMaTK(maTK).luongTheoGio;
                }
            }
        }

        public void SetCBB()
        {
            cbbNV.Items.Add(new CBBItem { value = "0", text = "Tất cả" });
            foreach (NHANVIEN nv in QLNhanVien.Instance.GetAll_NV(""))
            {
                cbbNV.Items.Add(new CBBItem { value = nv.maTK, text = nv.tenNV });
            }
        }
        public void ShowAllLuongNV(string thangLam, string maTK)
        {
            dtgvLuongNV.AutoGenerateColumns = false;
            dtgvLuongNV.DataSource = QLLuongNhanVien.Instance.GetLuongNVBy(thangLam, maTK);
            SetDTGV();
            SetSTT();
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvLuongNV.Rows.Count; i++)
            {
                dtgvLuongNV.Rows[i - 1].Cells[0].Value = i;
            }
        }
        private void QuanLyLuong_Load(object sender, EventArgs e)
        {
            SetSTT();
        }
        public void ShowTinhLuong(string thangLam)
        {
            dtgvLuongNV.AutoGenerateColumns = false;
            dtgvLuongNV.DataSource = QLLuongNhanVien.Instance.GetTongGioLV(thangLam);
            SetDTGV();
            SetSTT();
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            string thangLam = dtpkngayLuong.Value.ToString("MM/yyyy");
            if (QLLuongNhanVien.Instance.GetLuongNVBy(thangLam, "0").Count > 0)
            {
                MessageBox.Show("Tháng này đã được tính lương trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int month = dtpkngayLuong.Value.Date.Month;
                int year = dtpkngayLuong.Value.Date.Year;
                int MaxDay = DateTime.DaysInMonth(year, month);
                DateTime MaxDate = new DateTime(year,month,MaxDay);
                if (DateTime.Now.Date < MaxDate)
                {
                    DialogResult kq = MessageBox.Show("Tháng hiện tại chưa hết.\nBạn có muốn thanh toán lương cho nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.No)
                        return;
                }
                ShowTinhLuong(thangLam);
                foreach (DataGridViewRow dr in dtgvLuongNV.Rows)
                {
                    string maTK = dr.Cells["maTK"].Value.ToString();
                    string tenNV = dr.Cells["tenNV"].Value.ToString();
                    double tongGioLam = Convert.ToDouble(dr.Cells["tongGioLam"].Value);
                    double luongTheoGio = Convert.ToDouble(dr.Cells["luongTheoGio"].Value);
                    double tongTienLuong = Convert.ToDouble(dr.Cells["tienLuong"].Value);
                    LUONGNHANVIEN nv = new LUONGNHANVIEN()
                    {
                        maTK = maTK,
                        tenNV = tenNV,
                        soGioLam = tongGioLam,
                        thangLam = thangLam,
                        luongTheoGio = luongTheoGio,
                        tongLuong = tongTienLuong
                    };
                    QLLuongNhanVien.Instance.Add(nv);
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string thangLam = dtpkngayLuong.Value.ToString("MM/yyyy");
            string maTK = ((CBBItem)cbbNV.SelectedItem).value;
            if (QLLuongNhanVien.Instance.GetLuongNVBy(thangLam, maTK).Count > 0)
            {
                ShowAllLuongNV(thangLam, maTK);
            }
            else
            {
                MessageBox.Show("Chưa tính lương cho tháng " + thangLam + "\n Hoặc tháng này không có ca làm việc nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlLuong.Controls.Add(form);
            this.pnlLuong.Controls.SetChildIndex(form, 0);
            form.Show();
        }
        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            ShowForminPanel(new ChiTietCaLam());
        }
    }
}
