using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLThucDon
    {
        public static QLThucDon Instance = new QLThucDon();
        public string MaMA { get; set; }

        public List<LOAIMON> GetAllLMA()
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.LOAIMONs.Where(p => p.coXoa == false).Select(p => p).Distinct().ToList();
            return list;
        }

        public List<MONAN> GetAllMABy(string tenLM)
        {
            QLNH_DB db = new QLNH_DB();
            if (tenLM == "Tất cả")
            {
                var list = db.MONANs.Where(p => p.coXoa == false && p.LOAIMON.coXoa == false).Select(p => p).ToList();
                return list;
            }
            var list1 = db.MONANs.Where(p => p.LOAIMON.tenLM == tenLM && p.coXoa == false).ToList();
            return list1;
        }

        public MONAN GetMAByMaMA(string MaMA)
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.MONANs.Where(p => p.maMA == MaMA).FirstOrDefault();
            return list;
        }

        public void Add(MONAN monan)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.MONANs.OrderByDescending(a => a.maMA).Select(p => p.maMA).FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("MA", ""));
            num++;
            nextID = "MA" + num.ToString("D3");
            monan.maMA = nextID;
            db.MONANs.Add(monan);
            db.SaveChanges();
        }

        public void Update(MONAN monan)
        {
            QLNH_DB db = new QLNH_DB();
            MONAN ma = db.MONANs.Find(monan.maMA);
            ma.tenMA = monan.tenMA;
            ma.donViTinh = monan.donViTinh;
            ma.maLM = monan.maLM;
            ma.giaMA = monan.giaMA;
            ma.anhMA = monan.anhMA;
            db.SaveChanges();
        }

        public void Delete(string maMA)
        {
            QLNH_DB db = new QLNH_DB();
            MONAN ma = db.MONANs.Find(maMA);
            ma.coXoa = true;
            db.SaveChanges();
        }


    }
}
