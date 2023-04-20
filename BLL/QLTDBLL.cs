using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLTDBLL
    {
        public static QLTDBLL Instance = new QLTDBLL();

        public List<string> GetAllTLM()
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.LOAIMONs.Select(p => p.tenLM).ToList();
            return list;
        }
        public List<MONAN> GetAllMABy(string tenLM)
        {
            QLNH_DB db = new QLNH_DB();
            if (tenLM == "Tất cả")
            {
                var list1 = db.MONANs.Select(p => p).ToList();
                return list1;
            }
            var list2 = db.MONANs.Where(p => p.LOAIMON.tenLM == tenLM).ToList();
            return list2;
        }




    }
}
