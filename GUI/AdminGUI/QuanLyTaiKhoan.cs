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
using DoAnPBL3.DTO;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace DoAnPBL3
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            SetCbbVaitro();
            ShowAllTK("");
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvQLTK.Rows.Count; i++)
            {
                dtgvQLTK.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowAllTK(string txt)
        {
            dtgvQLTK.AutoGenerateColumns = false;
            dtgvQLTK.DataSource = QLTaiKhoan.Instance.GetAllAccount(txt);
            SetSTT();
        }
        public void SetCbbVaitro()
        {
            cbbVaitro.Items.AddRange(new object[]
            {
                "1","0"
            });
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            ShowAllTK(txt);
        }

        private void dtgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvQLTK.SelectedRows.Count > 0)
            {
                txtMaTK.Text = dtgvQLTK.SelectedRows[0].Cells["maTK"].Value.ToString();
                txtTendangnhap.Text = dtgvQLTK.SelectedRows[0].Cells["tenDangNhap"].Value.ToString();
                txtKytu.Text = dtgvQLTK.SelectedRows[0].Cells["kyTu"].Value.ToString();
                cbbVaitro.Text = Convert.ToInt32(dtgvQLTK.SelectedRows[0].Cells["vaiTro"].Value).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string phonePattern = @"\d{10}";
            Match match = Regex.Match(txtTendangnhap.Text, phonePattern);
            if (match.Success == false)
            {
                MessageBox.Show("Sai định dạng tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMathau.Text == "" || cbbVaitro.SelectedItem == null || txtKytu.Text == "")
            {
                MessageBox.Show("Thêm không thành công! Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TAIKHOAN tk = new TAIKHOAN
                {
                    maTK = txtMaTK.Text,
                    tenDangNhap = txtTendangnhap.Text,
                    matKhau = Convert_Password.Encode(txtMathau.Text),
                    kyTu = txtKytu.Text,
                    vaiTro = Convert.ToBoolean(cbbVaitro.SelectedItem.ToString() == "1" ? true : false),
                    coXoa = false
                };
                QLTaiKhoan.Instance.Add(tk);
                ShowAllTK("");
            }
        }


        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string phonePattern = @"\d{10}";
            Match match = Regex.Match(txtTendangnhap.Text, phonePattern);
            if (match.Success == false)
            {
                MessageBox.Show("Sai định dạng tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMathau.Text == "" || cbbVaitro.SelectedItem == null || txtKytu.Text == "")
            {
                MessageBox.Show("Thêm không thành công! Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtgvQLTK.SelectedRows.Count == 1)
                {
                    TAIKHOAN tk = new TAIKHOAN
                    {
                        maTK = txtMaTK.Text,
                        tenDangNhap = txtTendangnhap.Text,
                        matKhau = Convert_Password.Encode(txtMathau.Text),
                        kyTu = txtKytu.Text,
                        vaiTro = Convert.ToBoolean(cbbVaitro.SelectedItem.ToString() == "1" ? true : false)
                    };
                    QLTaiKhoan.Instance.Update(tk);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMathau.Text = "";
                    ShowAllTK("");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dtgvQLTK.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow dr in dtgvQLTK.SelectedRows)
                    {
                        list.Add(dr.Cells["maTK"].Value.ToString());
                    }
                    foreach (string i in list)
                    {
                        QLTaiKhoan.Instance.Delete(i);
                        ShowAllTK("");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "";
            txtTendangnhap.Text = "";
            txtMathau.Text = "";
            cbbVaitro.Text = "";
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            SetSTT();
        }
    }
}
