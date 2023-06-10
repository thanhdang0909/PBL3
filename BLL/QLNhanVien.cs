using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class QLNhanVien
    {
        public static QLNhanVien Instance = new QLNhanVien();

        public List<NHANVIEN> GetAll_NV(string txt)
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.NHANVIENs.Where(p => p.tenNV.Contains(txt) && p.coXoa == false && p.TAIKHOAN.vaiTro == false).ToList();
            return list;
        }
        public NHANVIEN GetNVByMaTK(string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            var nv = db.NHANVIENs.Where(p => p.maTK == maTK).Select(p => p).FirstOrDefault();
            return nv;
        }  
        public void Add(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.NHANVIENs
                              .Where(p => p.maNV.StartsWith("NV"))
                              .OrderByDescending(p => p.maNV)
                              .Select(p => p.maNV)
                              .FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("NV", ""));
            num++;
            nextID = "NV" + num.ToString("D3");
            nv.maNV = nextID;
            db.NHANVIENs.Add(nv);
            db.SaveChanges();
        }

        public void Update(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            NHANVIEN t = db.NHANVIENs.Find(nv.maNV);
            TAIKHOAN tk = db.TAIKHOANs.Find(nv.maTK);
            if (t != null)
            {
                t.tenNV = nv.tenNV;
                t.ngaySinh = nv.ngaySinh;
                t.SDT = nv.SDT;
                t.gioiTinh = nv.gioiTinh;
                t.diaChi = nv.diaChi;
                t.CCCD = nv.CCCD;
                t.luongTheoGio = nv.luongTheoGio;
                tk.tenDangNhap = nv.SDT;
                db.SaveChanges();
            }
        }
        public void Delete(string maNV, string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            nv.coXoa = true;
            TAIKHOAN tk = db.TAIKHOANs.Find(maTK);
            tk.coXoa = true;
            db.SaveChanges();
        }

    }
}
