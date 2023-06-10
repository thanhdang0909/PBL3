using DoAnPBL3.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnPBL3.BLL
{

    public class QLHoaDon
    {
        public static QLHoaDon Instance = new QLHoaDon();
        public string MaHD { get; set; }
        public double TongTien { get; set; }


        public List<object> GetAllHDBy(string ngayTT)
        {
            QLNH_DB db = new QLNH_DB();
            if (ngayTT == "")
            {
                var list = db.HOADONs.Select(p => new { p.maHD, p.maPV, p.TAIKHOAN.maTK, p.BANPHUCVU.maKH, p.ngayThanhToan, p.tongTien })
                    .ToList<object>();
                return list;
            }
            else
            {
                var list = db.HOADONs.ToList()
                           .Where(p => p.ngayThanhToan.Date.ToString("dd/MM/yyyy") == ngayTT)
                           .Select(p => new { p.maHD, p.maPV, p.TAIKHOAN.maTK, p.BANPHUCVU.maKH, p.ngayThanhToan, p.tongTien })
                           .ToList<object>();
                return list;
            }
        }

        public List<object> GetHDByMaHD(string maHD)
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.HOADONs
                     .Where(p => p.maHD == maHD).Select(p => new { p.maTK, p.BANPHUCVU.maKH, p.ngayThanhToan, p.tongTien })
                     .ToList<object>();
            return list;
        }

        public List<object> GetAllHDByMaTK(string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            if (maTK == "0")
            {
                var list = db.HOADONs
                         .Select(p => new { p.maHD, p.maPV, p.TAIKHOAN.maTK, p.BANPHUCVU.maKH, p.ngayThanhToan, p.tongTien })
                         .ToList<object>();
                return list;
            }
            else
            {

                var list = db.HOADONs.ToList()
                        .Where(p => p.maTK == maTK)
                        .Select(p => new { p.maHD, p.maPV, p.TAIKHOAN.maTK, p.BANPHUCVU.maKH, p.ngayThanhToan, p.tongTien })
                        .ToList<object>();
                return list;
            }
        }
        public void Add(HOADON hd)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.HOADONs.OrderByDescending(p => p.maHD)
                          .Select(p => p.maHD)
                          .FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("HD", ""));
            num++;
            nextID = "HD" + num.ToString("D3");
            hd.maHD = nextID;
            db.HOADONs.Add(hd);
            db.SaveChanges();
        }
    }
}
