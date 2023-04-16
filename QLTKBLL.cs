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
                        new UINhaHangNV().ShowDialog();
                        break;
                    case true:
                        new UINhahangAdmin().ShowDialog();
                        break;
                }

            }

        }
    }
}
