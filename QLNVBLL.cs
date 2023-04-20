using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class QLNVBLL
    {
        private static QLNVBLL _Instance;

        public static QLNVBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNVBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }

        public List<NHANVIEN> GetAll_NV(string txt)
        {
            QLNH_DB db = new QLNH_DB();
            if (txt == null)
            {
                var list = db.NHANVIENs.Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.NHANVIENs.Where(p => p.tenNV.Contains(txt)).ToList();
                return list;
            }

        }

        public void AddNV(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            db.NHANVIENs.Add(nv);
            db.SaveChanges();
        }
        public void UpdateNV(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            NHANVIEN t = db.NHANVIENs.Find(nv.maNV);

            t.maNV = nv.maNV;
            t.maTK = nv.maTK;
            t.tenNV = nv.tenNV;
            t.ngaySinh = nv.ngaySinh;
            t.SDT = nv.SDT;
            t.gioiTinh = nv.gioiTinh;
            t.diaChi = nv.diaChi;
            t.CCCD = nv.CCCD;
            t.luong = nv.luong;
            db.SaveChanges();
        }

    }
}
