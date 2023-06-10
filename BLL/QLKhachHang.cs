using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLKhachHang
    {
        public static QLKhachHang Instance = new QLKhachHang();
        public string MaKH { get; set ; }
        public string SDT { get; set; }

        public List<KHACHHANG> GetAllKHBy(string sdt)
        {
            QLNH_DB db = new QLNH_DB();
            if (sdt == "")
            {
                var list = db.KHACHHANGs.Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.KHACHHANGs.Where(p => p.SDT.Contains(sdt)).ToList();
                return list;
            }
        }

        public KHACHHANG GetKHByMa(string maKH)
        {
            QLNH_DB db = new QLNH_DB();
            KHACHHANG kh = db.KHACHHANGs.Find(maKH);
            return kh;
        }

        public void SetDiemTichLuy()
        {
            QLNH_DB db = new QLNH_DB();
            KHACHHANG kh = db.KHACHHANGs.Find(MaKH);
            kh.diemTichLuy += 1;
            kh.coKM = false;
            db.SaveChanges();
        }
        public void SetCoKM()
        {
            QLNH_DB db = new QLNH_DB();
            KHACHHANG kh = db.KHACHHANGs.Find(MaKH);
            kh.coKM = true;
            db.SaveChanges();
        }
        public void Update(KHACHHANG kh)
        {
            QLNH_DB db = new QLNH_DB();
            KHACHHANG k = db.KHACHHANGs.Find(kh.maKH);
            k.tenKH = kh.tenKH;
            k.SDT = kh.SDT;
            k.diaChi = kh.diaChi;
            k.gioiTinh = kh.gioiTinh;
            db.SaveChanges();
        }

        public void Add(KHACHHANG kh)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.KHACHHANGs
                          .OrderByDescending(a => a.maKH)
                          .Select(p => p.maKH)
                          .FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("KH", ""));
            num++;
            nextID = "KH" + num.ToString("D3");
            MaKH = nextID;
            kh.maKH = nextID;
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }

    }
}
