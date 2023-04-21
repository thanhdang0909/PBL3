using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnPBL3.BLL
{
    public class QLTKBLL
    {
        public static QLTKBLL Instance = new QLTKBLL();
        private string _tenDangNhap;
        public string tenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }

        public void DangNhap(string tendangnhap, string matkhau, bool vaitro)
        {
            QLNH_DB db = new QLNH_DB();
            var user = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap && p.matKhau == matkhau && p.vaiTro == vaitro).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Đăng nhập thất bại! \nSai tài khoản đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                switch (vaitro)
                {
                    case false:
                        new UINhahangNhanVien().ShowDialog();
                        break;
                    case true:
                        new UINhahangAdmin().ShowDialog();
                        break;
                }

            }
        }

        public NHANVIEN GetUserByTDN()
        {
            QLNH_DB db = new QLNH_DB();
            var NV = db.NHANVIENs.Where(p => p.SDT == _tenDangNhap).FirstOrDefault();
            return NV;
        }

        public void UpdateTTTK(string maTK, string tenDN, string tenNV, string diaChi)
        {
            QLNH_DB db = new QLNH_DB();
            TAIKHOAN taiKhoan = db.TAIKHOANs.Find(maTK);
            taiKhoan.tenDangNhap = tenDN;
            var nhanVien = db.NHANVIENs.Where(p => p.maTK == maTK).FirstOrDefault();
            nhanVien.tenNV = tenNV;
            nhanVien.SDT = tenDN;
            nhanVien.diaChi = diaChi;
            _tenDangNhap = tenDN;
            db.SaveChanges();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Check(string MKCu, string MKMoi, string MKMoiNhapLai)
        {
            QLNH_DB db = new QLNH_DB();
            var taiKhoan = db.TAIKHOANs.Where(p => p.tenDangNhap == _tenDangNhap).FirstOrDefault();
            if (taiKhoan.matKhau != MKCu)
            {
                MessageBox.Show("Nhập sai mật khẩu cũ","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    
                
            if (MKMoi != MKMoiNhapLai)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    
                
            return true;
        }
        public void SetPassWord(string MKCu, string MKMoi, string MKMoiNhapLai)
        {
            QLNH_DB db = new QLNH_DB();
            if(Check(MKCu,MKMoi,MKMoiNhapLai))
            {
                var taiKhoan = db.TAIKHOANs.Where(p => p.tenDangNhap == _tenDangNhap).FirstOrDefault();
                taiKhoan.matKhau = MKMoi;
                db.SaveChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
