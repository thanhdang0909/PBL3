using DoAnPBL3.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnPBL3.BLL
{
    public class QLDatBanDatMon
    {
        public static QLDatBanDatMon Instance = new QLDatBanDatMon();

        public string MaPV { get; set; }
        public string MaBan { get; set; }

        public List<object> GetAllCTDB(string maPV)
        {
            QLNH_DB db = new QLNH_DB();
            if (maPV == "")
            {
                var list = db.CHITIETBANPHUCVUs
                          .Select(p => new { p.maPV, p.MONAN.tenMA, p.soLuong, p.giaMA })
                          .ToList<object>();
                return list;
            }
            else
            {
                var list = db.CHITIETBANPHUCVUs.Where(p => p.maPV == maPV)
                          .Select(p => new { p.maPV, p.MONAN.tenMA, p.soLuong, p.giaMA })
                          .ToList<object>();
                return list;
            }
        }

        public void AddBanPhucVu(BANPHUCVU banPV)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.BANPHUCVUs.OrderByDescending(p => p.maPV)
                          .Select(p => p.maPV).FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("PV", ""));
            num++;
            nextID = "PV" + num.ToString("D3");
            banPV.maPV = nextID;
            MaPV = nextID;
            db.BANPHUCVUs.Add(banPV);
            db.SaveChanges();
        }
        public void AddMaKH(string maKH)
        {
            QLNH_DB db = new QLNH_DB();
            BANPHUCVU banPV = db.BANPHUCVUs.Find(MaPV);
            banPV.maKH = maKH;
            db.SaveChanges();
        }

        public void AddCTDatBan(CHITIETDATBAN ctdb)
        {
            QLNH_DB db = new QLNH_DB();
            db.CHITIETDATBANs.Add(ctdb);
            db.SaveChanges();
        }
        public void AddCTBanPhucVu(CHITIETBANPHUCVU ctpv)
        {
            QLNH_DB db = new QLNH_DB();
            db.CHITIETBANPHUCVUs.Add(ctpv);
            db.SaveChanges();
        }

       public List<CHITIETDATBAN> GetCTDB(string maPV,string ngayDat)
        {
            QLNH_DB db = new QLNH_DB();
            if(maPV == "" && ngayDat != "")
            {
                var list = db.CHITIETDATBANs.ToList()
                    .Where(p => p.BANPHUCVU.thoiGianVao.Date.ToString("dd/MM/yyyy") == ngayDat && p.BANAN.trangThai == "Đã đặt")
                    .GroupBy(p=>p.maBan)
                    .Select(g=>g.Last())
                    .ToList();
                return list;
            }  
            else
            {
                var list = db.CHITIETDATBANs.ToList()
                    .Where(p => p.maPV == maPV && p.BANAN.trangThai == "Đã đặt")
                    .GroupBy(p => p.maBan)
                    .Select(g => g.Last())
                    .ToList();
                return list;
            }   

        }

        public List<object> GetAllCTBPV(string maPV,string ngayDat)
        {
            QLNH_DB db = new QLNH_DB();
            if (maPV == "0")
            {
                var list = db.CHITIETBANPHUCVUs.ToList()
                        .Where(p=>p.BANPHUCVU.thoiGianVao.Date.ToString("dd/MM/yyyy") == ngayDat)
                        .Select(p => new { p.maPV, p.MONAN.maMA, p.MONAN.tenMA, p.soLuong, p.giaMA })
                        .ToList<object>();
                return list;
            }
            else
            {
                var list = db.CHITIETBANPHUCVUs.Where(p => p.maPV == maPV)
                        .Select(p => new { p.maPV, p.MONAN.maMA, p.MONAN.tenMA, p.soLuong, p.giaMA })
                        .ToList<object>();
                return list;
            }
        }

        public BANAN SetTrangThaiBA()
        {
            QLNH_DB db = new QLNH_DB();
            BANAN banan = db.BANANs.Where(p => p.maBan == MaBan).FirstOrDefault();
            banan.trangThai = "Đã đặt";
            db.SaveChanges();
            return banan;
        }

        public BANAN HuyTrangThai()
        {
            QLNH_DB db = new QLNH_DB();
            BANAN banan = db.BANANs.Where(p => p.maBan == MaBan).FirstOrDefault();
            banan.trangThai = "Trống";
            db.SaveChanges();
            return banan;
        }

        public void XoaBanDaDat()
        {
            QLNH_DB db = new QLNH_DB();
            List<CHITIETBANPHUCVU> ctbpv = db.CHITIETBANPHUCVUs.Where(p => p.maPV == MaPV).ToList();
            foreach(CHITIETBANPHUCVU ct in ctbpv)
            {
                db.CHITIETBANPHUCVUs.Remove(ct);
            }
            CHITIETDATBAN ctdb = db.CHITIETDATBANs.Where(p=>p.maPV == MaPV).FirstOrDefault();
            db.CHITIETDATBANs.Remove(ctdb);
            BANPHUCVU bpv = db.BANPHUCVUs.Find(MaPV);
            db.BANPHUCVUs.Remove(bpv);
            db.SaveChanges();
        }
        public void ChuyenBan(string maChuyen)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETDATBAN banDaDat = db.CHITIETDATBANs
                                   .Where(p => p.maBan == MaBan && p.BANAN.trangThai == "Đã đặt")
                                   .OrderByDescending(p => p.iD)
                                   .FirstOrDefault();
            if (banDaDat == null)
                MessageBox.Show("Bàn đang trống không thể chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                HuyTrangThai();
                banDaDat.maBan = maChuyen;
                MaBan = maChuyen;
                SetTrangThaiBA();
                db.SaveChanges();
                MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateDatMon(CHITIETBANPHUCVU ctpv)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETBANPHUCVU ct = db.CHITIETBANPHUCVUs
                                .Where(p => p.maPV == ctpv.maPV && p.MONAN.maMA == QLThucDon.Instance.MaMA)
                                .FirstOrDefault();
            ct.maMA = ctpv.maMA;
            ct.soLuong = ctpv.soLuong;
            ct.giaMA = ctpv.giaMA;
            db.SaveChanges();
        }
        public void XoaDatMon(string PV, string maMA)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETBANPHUCVU del = db.CHITIETBANPHUCVUs
                                 .Where(p => p.maPV == PV && p.maMA == maMA)
                                 .FirstOrDefault();
            db.CHITIETBANPHUCVUs.Remove(del);
            db.SaveChanges();
        }


        public List<object> GetLSDBByMaTK(string maTK)
        {
            QLNH_DB db = new QLNH_DB();
            if (maTK == "0")
            {
                var list = db.CHITIETDATBANs
                         .Select(p => new { p.maPV, p.maBan, p.BANPHUCVU.maKH, p.BANPHUCVU.maTK, p.BANPHUCVU.thoiGianVao, p.BANAN.soGhe })
                         .ToList<object>();
                return list;
            }
            else
            {
                var list = db.CHITIETDATBANs.Where(p => p.BANPHUCVU.maTK == maTK)
                         .Select(p => new { p.maPV, p.maBan, p.BANPHUCVU.maKH, p.BANPHUCVU.maTK, p.BANPHUCVU.thoiGianVao, p.BANAN.soGhe })
                         .ToList<object>();
                return list;
            }

        }
    }
}
