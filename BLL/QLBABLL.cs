using DoAnPBL3.DTO;
using DoAnPBL3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLBABLL
    {
        public static QLBABLL Instance = new QLBABLL();
    
        
        // Search
        public List<BANAN> GetAllBABy(string trangThai,string soGhe)
        {
            QLNH_DB db = new QLNH_DB();
            int SG;
            if(trangThai == "Tất cả" && soGhe != "")
            {
                SG = Convert.ToInt32(soGhe);
                var list = db.BANANs.Where(p => p.soGhe == SG);
                return list.ToList();
            }
            else if(trangThai == "Tất cả" && soGhe == "")
            {
               var list = db.BANANs.Select(p => p);
                return list.ToList();
            }    
            else if(soGhe == "")
            {
                var list = db.BANANs.Where(p => p.trangThai == trangThai);
                return list.ToList();
            } 
            else
            {
                SG = Convert.ToInt32(soGhe);
                var list = db.BANANs.Where(p => p.trangThai == trangThai && p.soGhe == SG);
                return list.ToList();
            }
        }

        public void Add(BANAN ba)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.BANANs.OrderByDescending(p => p.maBan).Select(p => p.maBan).FirstOrDefault();
            string nextID = "";
            if(lastID != "")
            {
                int num = int.Parse(lastID.Replace("MB",""));
                num++;
                nextID = "MB" + num.ToString("D3");
            }
            ba.maBan = nextID;
            db.BANANs.Add(ba);
            db.SaveChanges();
        }    

        public void Update(BANAN ba)
        {
            QLNH_DB db = new QLNH_DB();
            BANAN ban = db.BANANs.Find(ba.maBan);
            ban.soGhe = ba.soGhe;
            ban.ghiChu = ba.ghiChu;
            db.SaveChanges();
        }


        
    }
}
