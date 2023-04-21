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
using DoAnPBL3.DTO;
using System.Globalization;

namespace DoAnPBL3
{
    public partial class QuanLyCaTruc : Form
    {
        public QuanLyCaTruc()
        {
            InitializeComponent();
            SetCBB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetCBB()
        {
            cbbTrangthai.Items.AddRange(new object[]
            {
                "Tất cả", "1", "0"
            });
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DateTime ngaylam;
            if (DateTime.TryParseExact(txtTimkiem.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaylam))
            {
                dtgvCatruc.DataSource = QLCTBLL.Instance.GetAll_CaTruc(ngaylam);
            }
            else
            {
                MessageBox.Show("Định dạng ngày tháng không hợp lệ! Vui lòng nhập đúng định dạng ngày tháng dd/mm/yyyy");
            }
        }

        private void dtgvCatruc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCatruc.SelectedRows.Count > 0)
            {
                txtMacatruc.Text = dtgvCatruc.SelectedRows[0].Cells["maCT"].Value.ToString();
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["ngayLam"].Value.ToString(), out DateTime ngaylam))
                {
                    dtmNgaylam.Value = ngaylam;
                }
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["gioBatDau"].Value.ToString(), out DateTime giobatdau))
                {
                    dtmGiobatdau.Value = giobatdau;
                }
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["gioKetThuc"].Value.ToString(), out DateTime gioketthuc))
                {
                    dtmGioketthuc.Value = gioketthuc;
                }
                txtSoluong.Text = Convert.ToInt32(dtgvCatruc.SelectedRows[0].Cells["soLuong"].Value).ToString();
                cbbTrangthai.Text = Convert.ToBoolean(dtgvCatruc.SelectedRows[0].Cells["trangThai"].Value).ToString();
            }
            else return;
        }
    }
}
