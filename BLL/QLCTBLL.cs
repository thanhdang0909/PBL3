using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class QLCTBLL
    {
        private static QLCTBLL _Instance;
        public static QLCTBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLCTBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<CHITIETCALAM> GetAll_CaTruc(DateTime ngaylam)
        {
            QLNH_DB db = new QLNH_DB();
            if (ngaylam != DateTime.MinValue)
            {
                var ct = db.CHITIETCALAMs.Where(p => p.ngayLam == ngaylam).ToList();
                return ct;
            }
            else
            {
                var ct = db.CHITIETCALAMs.Select(p => p).ToList();
                return ct;
            }
            
        }
        
    }
}
