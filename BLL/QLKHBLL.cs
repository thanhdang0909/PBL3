using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLKHBLL
    {
        public static QLKHBLL Instance = new QLKHBLL();

        public List<KHACHHANG> GetAllKHBy(string sdt)
        {
            QLNH_DB db = new QLNH_DB();
            if (sdt == "")
            {
                // var list = db.KHACHHANGs.Select(p=>new {p.maKH,p.tenKH,p.SDT,p.diaChi,p.gioiTinh}).ToList();
                var list = db.KHACHHANGs.Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.KHACHHANGs.Where(p => p.SDT == sdt).ToList();
                return list;
            }
        }

        public void Update(KHACHHANG kh)
        {
            QLNH_DB db = new QLNH_DB();
            KHACHHANG k = db.KHACHHANGs.Find(kh.maKH);
            k.tenKH = kh.tenKH;
            k.maKH = kh.maKH;
            k.SDT = kh.SDT;
            k.diaChi = kh.diaChi;
            k.gioiTinh = kh.gioiTinh;
            db.SaveChanges();
        }
        
        public void Add(KHACHHANG kh)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.KHACHHANGs.OrderByDescending(a => a.maKH).Select(p => p.maKH).FirstOrDefault();
            string nextID = "";
            if(lastID != "") 
            {
               int num = int.Parse(lastID.Replace("KH",""));
                num++;
                nextID = "KH" + num.ToString("D3");
            }
            kh.maKH = nextID;
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }
    }
}
