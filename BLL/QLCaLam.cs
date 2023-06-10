using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3.BLL
{
    class QLCaLamBLL
    {
        public static QLCaLamBLL Instance = new QLCaLamBLL();

        public List<CHITIETCALAM> GetAllCaLam(string ngaylam)
        {
            QLNH_DB db = new QLNH_DB();
            if (ngaylam == "")
            {
                var ct = db.CHITIETCALAMs.Select(p => p).ToList();
                return ct;
            }
            else
            {
                var ct = db.CHITIETCALAMs.ToList().Where(p => p.ngayLam.Date.ToString("dd/MM/yyyy") == ngaylam).ToList();
                return ct;
            }
        }

        public void Add(CHITIETCALAM ct)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.CHITIETCALAMs.OrderByDescending(p => p.maCT)
                           .Select(p => p.maCT).FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("CT", ""));
            num++;
            nextID = "CT" + num.ToString("D3");
            ct.maCT = nextID;
            db.CHITIETCALAMs.Add(ct);
            db.SaveChanges();
        }

        public void Update(CHITIETCALAM ct)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETCALAM d = db.CHITIETCALAMs.Find(ct.maCT);
                d.ngayLam = ct.ngayLam;
                d.gioBatDau = ct.gioBatDau;
                d.gioKetThuc = ct.gioKetThuc;
                d.soLuong = ct.soLuong;
            db.SaveChanges();
        }

        public void Delete(string mact)
        {
            QLNH_DB db = new QLNH_DB();
            var pc = db.PHANCONGCALAMs.Where(p => p.maCT == mact).ToList();
            var ct = db.CHITIETCALAMs.Where(p => p.maCT == mact).FirstOrDefault();
            foreach (PHANCONGCALAM i in pc)
            {
                db.PHANCONGCALAMs.Remove(i);
            }
            db.CHITIETCALAMs.Remove(ct);
            db.SaveChanges();
        }

        public bool CheckSoLuong(string mact)
        {
            QLNH_DB db = new QLNH_DB();
            int SLYeuCau = db.CHITIETCALAMs.Where(p => p.maCT == mact)
                                           .Select(p => p.soLuong).FirstOrDefault();
            int SLNVDangKy = db.PHANCONGCALAMs.Where(p => p.maCT == mact).Count();
            return SLNVDangKy < SLYeuCau;
        }

        public bool CheckSLToiDa(DateTime ngayLam, string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            int SoLuong = db.PHANCONGCALAMs
                .Where(p => p.maTK == maTK && p.CHITIETCALAM.ngayLam == ngayLam)
                .Count();
            return SoLuong < 3;
        }

        public bool CheckDaDK(string maCT, string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.PHANCONGCALAMs.Where(p => p.maCT == maCT && p.maTK == maTK);
            return list.Any();
        }
        public CHITIETCALAM GetCaLamByMa(string MaCT)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETCALAM caLam = db.CHITIETCALAMs.Where(p => p.maCT == MaCT).FirstOrDefault();
            return caLam;
        }
        public void DangKyCaLam(PHANCONGCALAM pc)
        {
            QLNH_DB db = new QLNH_DB();
            db.PHANCONGCALAMs.Add(pc);
            db.SaveChanges();
        }

        public bool CheckHuyCaLam(string mact, string matk)
        {
            QLNH_DB db = new QLNH_DB();
            var huycalam = db.PHANCONGCALAMs.Where(p => p.maCT == mact && p.maTK == matk).FirstOrDefault();
            return huycalam != null;
        }
        public void HuyCaLam(string mact, string matk)
        {
            QLNH_DB db = new QLNH_DB();
            var huycalam = db.PHANCONGCALAMs.Where(p => p.maCT == mact && p.maTK == matk).FirstOrDefault();
            db.PHANCONGCALAMs.Remove(huycalam);
            var chitietcalam = db.CHITIETCALAMs.Where(p => p.maCT == mact).FirstOrDefault();
            chitietcalam.trangThai = false;
            db.SaveChanges();
        }

        public void SetTrangThai(string mact)
        {
            if (CheckSoLuong(mact) == false)
            {
                QLNH_DB db = new QLNH_DB();
                var check = db.CHITIETCALAMs.Where(p => p.maCT == mact).FirstOrDefault();
                check.trangThai = true;
                db.SaveChanges();
            }
        }
        public List<object> GetCaLamPC(string ngayLam, string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            if (maTK == null)
            {
                var ct = db.PHANCONGCALAMs.ToList()
                         .Where(p => p.CHITIETCALAM.ngayLam.Date.ToString("dd/MM/yyyy").Contains(ngayLam) && p.CHITIETCALAM.maCT == p.maCT && p.TAIKHOAN.maTK == p.maTK)
                         .Select(p => new
                         {
                             p.maTK,
                             tenNV = db.NHANVIENs.Where(a => a.maTK == p.maTK).Select(a => a.tenNV).FirstOrDefault(),
                             p.CHITIETCALAM.maCT,
                             p.CHITIETCALAM.ngayLam,
                             p.CHITIETCALAM.gioBatDau,
                             p.CHITIETCALAM.gioKetThuc,
                             p.thoiGianDangKy
                         })
                         .ToList<object>();
                return ct;
            }
            else
            {
                var ct = db.PHANCONGCALAMs.ToList()
                .Where(p => p.CHITIETCALAM.ngayLam.Date.ToString("dd/MM/yyyy").Contains(ngayLam) && p.maTK == maTK)
                .Select(p => new
                {
                    p.maTK,
                    tenNV = db.NHANVIENs.Where(a => a.maTK == p.maTK).Select(a => a.tenNV).FirstOrDefault(),
                    p.CHITIETCALAM.maCT,
                    p.CHITIETCALAM.ngayLam,
                    p.CHITIETCALAM.gioBatDau,
                    p.CHITIETCALAM.gioKetThuc,
                    p.thoiGianDangKy
                })
                .ToList<object>();
                return ct;
            }
        }
    }

}

