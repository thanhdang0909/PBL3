using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLLuongNhanVien
    {
        public static QLLuongNhanVien Instance = new QLLuongNhanVien();

        public List<LUONGNHANVIEN> GetLuongNVBy(string thangLam,string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            List<LUONGNHANVIEN> list;
            if (maTK == "0")
            {
               list = db.LUONGNHANVIENs.Where(p => p.thangLam == thangLam)
                                       .Select(p => p).ToList();
                return list;
            }
            else
            {
                list = db.LUONGNHANVIENs.Where(p=>p.thangLam == thangLam && p.TAIKHOAN.maTK == maTK)
                                        .Select(p => p).ToList();
                return list;
            }
        }
       
        public List<object> GetTongGioLV(string thangLam)
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.PHANCONGCALAMs.ToList()
           .Where(p => p.CHITIETCALAM.ngayLam.ToString("MM/yyyy") == thangLam)
           .GroupBy(p => p.maTK)
           .Select(p => new
           {
               maTK = p.Key,
               soGioLam = Math.Round(p.Sum(q => (q.CHITIETCALAM.gioKetThuc - q.CHITIETCALAM.gioBatDau).TotalHours),3)
           }).ToList<object>();
            return list;
        }

        public void Add(LUONGNHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            db.LUONGNHANVIENs.Add(nv);
            db.SaveChanges();
        }
        public void Delete(int ID)
        {
            QLNH_DB db = new QLNH_DB();
            LUONGNHANVIEN nv = db.LUONGNHANVIENs.Where(p => p.iD == ID).FirstOrDefault();
            db.LUONGNHANVIENs.Remove(nv);
            db.SaveChanges();
        }
    }
}
