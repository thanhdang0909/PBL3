using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
     class QLTDBLL
     {
        private static QLTDBLL _Instance;

        public static QLTDBLL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new QLTDBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }

        public List<MONAN> GetAll_MonAn(string txt)
        {
            QLNH_DB db = new QLNH_DB();
            if(txt == null)
            {
                var list = db.MONANs.Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.MONANs.Where(p => p.tenMA.Contains(txt)).ToList();
                return list;
            }
        }
     }
}
