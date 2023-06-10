using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace DoAnPBL3.BLL
{
    class QLThongKeBLL
    {
        public static QLThongKeBLL Instance = new QLThongKeBLL();
      
        public List<object> DoanhThu(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            if (txt == "Theo ngày")
            {
                List<object> list = db.HOADONs.ToList()
                    .Where(p => p.ngayThanhToan.Date >= startDate && p.ngayThanhToan.Date <= endDate)
                    .GroupBy(p => p.ngayThanhToan.Date).
                     Select(p => new {
                     ngaythanhtoan = p.Key,
                     tongtien = p.Sum(h => h.tongTien)
                 })
                    .ToList<object>();
                return list;
            }
            else if (txt == "Theo tháng")
            {
                List<object> list = db.HOADONs.ToList()
                  .Where(p => p.ngayThanhToan.Date >= startDate && p.ngayThanhToan.Date <= endDate)
                  .GroupBy(p => new { p.ngayThanhToan.Date.Month, p.ngayThanhToan.Year }).
                   Select(p => new {
                   ngaythanhtoan = new DateTime(p.Key.Year, p.Key.Month, 1),
                   tongtien = p.Sum(h => h.tongTien)
               })
                  .ToList<object>();
                return list;
            }
            else
            {
                List<object> list = db.HOADONs.ToList()
                 .Where(p => p.ngayThanhToan.Date >= startDate && p.ngayThanhToan.Date <= endDate)
                 .GroupBy(p => p.ngayThanhToan.Date.Year).
                  Select(p => new {
                  ngaythanhtoan = new DateTime(p.Key, 1, 1),
                  tongtien = p.Sum(h => h.tongTien)
              })
                 .ToList<object>();
                return list;
            }

        }

        public double TongDoanhThu(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            double sum = 0;
            foreach (dynamic i in DoanhThu(startDate, endDate, txt))
            {
                sum += Convert.ToDouble(i.tongtien);
            }
            return sum;
        }

        public List<object> ThucDon(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            List<object> thucdon;

            if (txt == "Theo ngày")
            {
                thucdon = db.CHITIETBANPHUCVUs.ToList()
                    .Where(p => p.maMA == p.MONAN.maMA &&
                                p.maPV == p.BANPHUCVU.maPV &&
                                p.BANPHUCVU.thoiGianVao >= startDate.Date &&
                                p.BANPHUCVU.thoiGianVao <= endDate.Date)
                    .GroupBy(p => new { p.MONAN.tenMA, p.BANPHUCVU.thoiGianVao.Date })
                    .Select(p => new
                    {
                        tenmonan = p.Key.tenMA,
                        thoigian = p.Key.Date,
                        soluongmon = p.Sum(h => h.soLuong)
                    })
                    .OrderByDescending(p => p.soluongmon)
                    .Take(5)
                     .ToList<object>();
            }
            else if (txt == "Theo tháng")
            {
                thucdon = db.CHITIETBANPHUCVUs.ToList()
                    .Where(p => p.maMA == p.MONAN.maMA &&
                                p.maPV == p.BANPHUCVU.maPV &&
                                p.BANPHUCVU.thoiGianVao >= startDate.Date &&
                                p.BANPHUCVU.thoiGianVao <= endDate.Date)
                    .GroupBy(p => new { p.MONAN.tenMA, p.BANPHUCVU.thoiGianVao.Month, p.BANPHUCVU.thoiGianVao.Year })
                    .Select(p => new
                    {
                        tenmonan = p.Key.tenMA,
                        thoigian = new DateTime(p.Key.Year, p.Key.Month, 1),
                        soluongmon = p.Sum(h => h.soLuong)
                    })
                    .OrderByDescending(p => p.soluongmon)
                    .Take(5)
                    .ToList<object>();
            }
            else
            {
                thucdon = db.CHITIETBANPHUCVUs.ToList()
                    .Where(p => p.maMA == p.MONAN.maMA &&
                                p.maPV == p.BANPHUCVU.maPV &&
                                p.BANPHUCVU.thoiGianVao >= startDate.Date &&
                                p.BANPHUCVU.thoiGianVao <= endDate.Date)
                    .GroupBy(p => new { p.MONAN.tenMA, p.BANPHUCVU.thoiGianVao.Year })
                    .Select(p => new
                    {
                        tenmonan = p.Key.tenMA,
                        thoigian = new DateTime(p.Key.Year, 1, 1),
                        soluongmon = p.Sum(h => h.soLuong)
                    })
                    .OrderByDescending(p => p.soluongmon)
                    .Take(5)
                    .ToList<object>();
            }

            return thucdon;
        }

        public double Tongmonan(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            double sum = 0;
            foreach (dynamic i in ThucDon(startDate, endDate, txt))
            {
                sum += Convert.ToDouble(i.soluongmon);
            }
            return sum;
        }


        public List<object> KhachHang(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            if (txt == "Theo ngày")
            {
                var kh = db.CHITIETDATBANs.ToList()
                .Where(p => p.maPV == p.BANPHUCVU.maPV && p.maBan == p.BANAN.maBan && p.BANPHUCVU.thoiGianVao.Date >= startDate && p.BANPHUCVU.thoiGianVao.Date <= endDate)
                .GroupBy(p => p.BANPHUCVU.thoiGianVao.Date)
                .Select(p => new { ngayDen = p.Key, tongSoNguoi = p.Sum(h => h.BANAN.soGhe) })
                .ToList<object>();
                return kh;
            }
            else if (txt == "Theo tháng")
            {
                var kh = db.CHITIETDATBANs.ToList()
                .Where(p => p.maPV == p.BANPHUCVU.maPV && p.maBan == p.BANAN.maBan && p.BANPHUCVU.thoiGianVao.Date >= startDate && p.BANPHUCVU.thoiGianVao.Date <= endDate)
                .GroupBy(p => new { p.BANPHUCVU.thoiGianVao.Year, p.BANPHUCVU.thoiGianVao.Month })
                .Select(p => new { ngayDen = new DateTime(p.Key.Year, p.Key.Month, 1), tongSoNguoi = p.Sum(h => h.BANAN.soGhe) })
                .ToList<object>();
                return kh;
            }
            else
            {
                var kh = db.CHITIETDATBANs.ToList()
                .Where(p => p.maPV == p.BANPHUCVU.maPV && p.maBan == p.BANAN.maBan && p.BANPHUCVU.thoiGianVao.Date >= startDate && p.BANPHUCVU.thoiGianVao.Date <= endDate)
                .GroupBy(p => p.BANPHUCVU.thoiGianVao.Date.Year)
                .Select(p => new { ngayDen = new DateTime(p.Key, 1, 1), tongSoNguoi = p.Sum(h => h.BANAN.soGhe) })
                .ToList<object>();
                return kh;
            }
        }
        public int TongKhachhang(DateTime startDate, DateTime endDate, string txt)
        {
            QLNH_DB db = new QLNH_DB();
            int sum = 0;
            foreach (dynamic kh in KhachHang(startDate,endDate,txt))
            {
                sum += kh.tongSoNguoi;
            }
            return sum;
        }
        public bool Check(DateTime dayStart, DateTime dayEnd)
        {
            if (dayStart > dayEnd)
                return false;
            return true;
        }
    }
}
