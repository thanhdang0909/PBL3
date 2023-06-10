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
using TheArtOfDevHtmlRenderer.Adapters;
using DoAnPBL3.DTO;
using System.Text.RegularExpressions;

namespace DoAnPBL3
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            ShowAllNV("");
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvNhanvien.Rows.Count; i++)
            {
                dtgvNhanvien.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowAllNV(string txt)
        {
            dtgvNhanvien.AutoGenerateColumns = false;
            dtgvNhanvien.DataSource = QLNhanVien.Instance.GetAll_NV(txt);
            SetSTT();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            ShowAllNV(txt); ;
        }

        private void dtgvNhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvNhanvien.SelectedRows.Count > 0)
            {
                txtMaNV.Text = dtgvNhanvien.SelectedRows[0].Cells["maNV"].Value.ToString();
                txtMaTK.Text = dtgvNhanvien.SelectedRows[0].Cells["maTK"].Value.ToString();
                txtTenNV.Text = dtgvNhanvien.SelectedRows[0].Cells["tenNV"].Value.ToString();
                if (Convert.ToBoolean(dtgvNhanvien.SelectedRows[0].Cells["gioiTinh"].Value.ToString()))
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                dtmNgaysinh.Value = Convert.ToDateTime(dtgvNhanvien.SelectedRows[0].Cells["ngaySinh"].Value);
                txtCCCD.Text = dtgvNhanvien.SelectedRows[0].Cells["CCCD"].Value.ToString();
                txtSDT.Text = dtgvNhanvien.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtDiachi.Text = dtgvNhanvien.SelectedRows[0].Cells["diaChi"].Value.ToString();
                txtLuong.Text = Convert.ToDouble(dtgvNhanvien.SelectedRows[0].Cells["luongTheoGio"].Value).ToString("#,###");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string phonePattern = @"\d{10}";
                string CCCDPattern = @"\d{12}";
                Match matchSDT = Regex.Match(txtSDT.Text, phonePattern);
                Match matchCCCD = Regex.Match(txtCCCD.Text, CCCDPattern);
                if (matchSDT.Success == false || matchCCCD.Success == false)
                {
                    MessageBox.Show("Sai định dạng số điện thoại hoặc CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtMaTK.Text == "" || txtTenNV.Text == "" || txtDiachi.Text == "" || txtLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        maNV = txtMaNV.Text,
                        maTK = txtMaTK.Text,
                        tenNV = txtTenNV.Text,
                        gioiTinh = rdoNam.Checked ? true : false,
                        ngaySinh = dtmNgaysinh.Value,
                        CCCD = txtCCCD.Text,
                        SDT = txtSDT.Text,
                        diaChi = txtDiachi.Text,
                        luongTheoGio = Convert.ToDouble(txtLuong.Text),
                        coXoa = false,
                    };
                    if (QLNhanVien.Instance.GetNVByMaTK(nv.maTK) != null)
                    {
                        MessageBox.Show("Tài khoản đã được đã được đăng ký! Vui lòng chọn tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        QLNhanVien.Instance.Add(nv);
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllNV("");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string phonePattern = @"\d{10}";
                string CCCDPattern = @"\d{12}";
                Match matchSDT = Regex.Match(txtSDT.Text, phonePattern);
                Match matchCCCD = Regex.Match(txtCCCD.Text, CCCDPattern);
                if (matchSDT.Success == false || matchCCCD.Success == false)
                {
                    MessageBox.Show("Sai định dạng số điện thoại hoặc CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtDiachi.Text == "" || txtLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtgvNhanvien.SelectedRows.Count == 1)
                    {
                        NHANVIEN nv = new NHANVIEN
                        {
                            maNV = txtMaNV.Text,
                            maTK = txtMaTK.Text,
                            tenNV = txtTenNV.Text,
                            gioiTinh = rdoNam.Checked ? true : false,
                            ngaySinh = dtmNgaysinh.Value,
                            CCCD = txtCCCD.Text,
                            SDT = txtSDT.Text,
                            diaChi = txtDiachi.Text,
                            luongTheoGio = Convert.ToDouble(txtLuong.Text)
                        };
                        QLNhanVien.Instance.Update(nv);
                        ShowAllNV("");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaTK.Text = "";
            txtTenNV.Text = "";
            txtCCCD.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtmNgaysinh.Value = DateTime.Now;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvNhanvien.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Bạn chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> listMaNV = new List<string>();
                    List<string> listMaTK = new List<string>();
                    foreach(DataGridViewRow dr in dtgvNhanvien.SelectedRows)
                    {
                        listMaNV.Add(dr.Cells["maNV"].Value.ToString());
                        listMaTK.Add(dr.Cells["maTK"].Value.ToString());
                    }    
                    for(int i = 0; i <listMaNV.Count; i++)
                    {
                        QLNhanVien.Instance.Delete(listMaNV[i], listMaTK[i]);
                    }
                    ShowAllNV("");
                }
            } 
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            
        }
    }
}
