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
        private static QLTKBLL _Instance;
        public string Tendangnhap { get; set; }

        public static QLTKBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTKBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
       
        public void DangNhap(string tendangnhap, string matkhau, bool vaitro)
        {
            QLNH_DB db = new QLNH_DB();
          
                var user = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap && p.matKhau == matkhau && p.vaiTro == vaitro).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng nhập đúng tên đăng nhập hoặc mật khẩu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    this.Tendangnhap = tendangnhap;
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

        //public dynamic Thongtintaikhoan()
        //{
        //    QLNH_DB db = new QLNH_DB();
        //    var user = db.TAIKHOANs.Join(db.NHANVIENs, taikhoan => taikhoan.maTK, nhanvien => nhanvien.maTK, (taikhoan, nhanvien) => new { taikhoan, nhanvien })
        //    .Where(p => p.taikhoan.tenDangNhap == Tendangnhap)
        //    .Select(p => new
        //    {
        //        p.taikhoan.maTK,
        //        p.taikhoan.tenDangNhap,
        //        p.nhanvien.tenNV,
        //        p.nhanvien.SDT,
        //        p.nhanvien.diaChi
        //    }).FirstOrDefault();
        //    return user;
        //}
        public void UpdateThongtintaikhoan(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            NHANVIEN t = db.NHANVIENs.Find(nv.maTK);
            t.tenNV = nv.tenNV;
            t.SDT = nv.SDT;
            t.diaChi = nv.diaChi;
            db.SaveChanges();
        }
        public bool CheckDoiMK(string matkhaucu, string matkhaumoi, string xacnhanmatkhau)
        {
            if (matkhaucu == "" && matkhaumoi == "" && xacnhanmatkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (matkhaucu == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (matkhaumoi == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (xacnhanmatkhau == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (xacnhanmatkhau != matkhaumoi)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp với mật khẩu mới! Vui lòng nhập lại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public void Doimatkhau(string matkhaucu, string matkhaumoi, string xacnhanmatkhau)
        {


            QLNH_DB db = new QLNH_DB();
            if (CheckDoiMK(matkhaucu, matkhaumoi, xacnhanmatkhau))
            {
                var user = db.TAIKHOANs.Where(p => p.tenDangNhap == Tendangnhap).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (user.matKhau != matkhaucu)
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    user.matKhau = matkhaumoi;
                    db.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        public void DangXuat()
        {

        }
        public List<TAIKHOAN> GetAll_TaiKhoan(string tentaikhoan, string cbb)
        {

            QLNH_DB db = new QLNH_DB();
            if (string.IsNullOrEmpty(tentaikhoan) && string.IsNullOrEmpty(cbb) || cbb == "All")
            {
                var list = db.TAIKHOANs.Select(p => p).ToList();
                return list;
            }
            else
            {
                bool vaitro = true;
                if (cbb == "0")
                {
                    vaitro = false;
                }
                var list = db.TAIKHOANs.Where(p => p.tenDangNhap.Contains(tentaikhoan) && p.vaiTro == vaitro).ToList();
                return list;
            }
        }
        public void AddTaikhoan(TAIKHOAN tk)
        {
            QLNH_DB db = new QLNH_DB();
            TAIKHOAN t = new TAIKHOAN
            {
                maTK = tk.maTK,
                tenDangNhap = tk.tenDangNhap,
                matKhau = tk.matKhau,
                vaiTro = tk.vaiTro,
            };
            db.SaveChanges();
        }
        public void UpdateTaikhoan(TAIKHOAN tk)
        {
            QLNH_DB db = new QLNH_DB();
            TAIKHOAN t = db.TAIKHOANs.Find(tk.maTK);

            t.maTK = tk.maTK;
            t.tenDangNhap = tk.tenDangNhap;
            t.matKhau = tk.matKhau;
            t.vaiTro = tk.vaiTro;
            db.SaveChanges();
        }
        public void DeleteTaikhoan()
        {

        }
        public NHANVIEN GetUserByTDN()
        {
            QLNH_DB db = new QLNH_DB();
            var NV = db.NHANVIENs.Where(p => p.SDT == Tendangnhap).FirstOrDefault();
            return NV;
        }

        //public void UpdateTTTK(string maTK, string tenDN, string tenNV, string diaChi)
        //{
        //    QLNH_DB db = new QLNH_DB();
        //    TAIKHOAN taiKhoan = db.TAIKHOANs.Find(maTK);
        //    taiKhoan.tenDangNhap = tenDN;
        //    var nhanVien = db.NHANVIENs.Where(p => p.maTK == maTK).FirstOrDefault();
        //    nhanVien.tenNV = tenNV;
        //    nhanVien.SDT = tenDN;
        //    nhanVien.diaChi = diaChi;
        //    _tenDangNhap = tenDN;
        //    db.SaveChanges();
        //    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

    }
}
