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

namespace DoAnPBL3.GUI
{
    public partial class LuongNhanVien : Form
    {
        public LuongNhanVien()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string thangLam = dtpkThangLam.Value.ToString("MM/yyyy");
            string tenDN = QLTaiKhoan.Instance.TenDangNhap;
            string maTK = QLTaiKhoan.Instance.GetAllAccount(tenDN)[0].maTK;
            dtgvLuong.AutoGenerateColumns = false;
            dtgvLuong.DataSource = QLLuongNhanVien.Instance.GetLuongNVBy(thangLam, maTK);
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
