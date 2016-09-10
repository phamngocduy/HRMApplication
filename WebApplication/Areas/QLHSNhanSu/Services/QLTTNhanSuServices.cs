using System;
using System.Data;
using System.Linq;

using HRM.Webpages.Helpers;
using HRM.Databases.Models;
using HRM.QLTTNhanSu.Models;
namespace HRM.QLTTNhanSu.Services
{
    public class QLTTNhanSuServices
    {
        public static int tinhThamNienGiangDay(HRMDB0Entities db, int NhanVien_id)
        {
            var nv = db.NhanViens.All.Find(NhanVien_id);
            return tinhThamNienGiangDay(db, nv);
        }
        public static int tinhThamNienGiangDay(HRMDB0Entities db, NhanVien nv)
        {
            var tongThoiGian = new DateRanges();
            
            foreach (var ct in db.nvQTLamViec.Where(ct => ct.NV_id == nv.id)
                .Where(ct => ct.ChucDanhChucVu_id.HasValue && ct.ChucDanhChuyenMon.laDayHoc))
                /*if (ct.ChucDanhChuyenMon.tenChucDanhChuyenMon.ToLower().Contains("giảng")
                 || ct.ChucDanhChuyenMon.tenChucDanhChuyenMon.ToLower().Contains("giáo"))*/
                    tongThoiGian.Add(ct.ThoiGianBatDau, ct.ThoiGianKetThuc);
            return tongThoiGian.ToMonths() +
                db.NhanViens.All.Find(nv.id).nvTTMoRongs.Single().ThamNienGiangDay_Truoc;
        }

        public static int tinhThamNienTaiTruong(HRMDB0Entities db, int NhanVien_id)
        {
            var nv = db.NhanViens.All.Find(NhanVien_id);
            return tinhThamNienTaiTruong(db, nv);
        }
        public static int tinhThamNienTaiTruong(HRMDB0Entities db, NhanVien nv)
        {
            var tongThoiGian = new DateRanges();
            foreach (var ct in db.nvQTLamViec.Where(ct => ct.NV_id == nv.id))
            {
                tongThoiGian.Add(ct.ThoiGianBatDau, ct.ThoiGianKetThuc);
            }
            foreach (var lv in db.nvQTNghiNganHan.Where(lv => lv.CongTac.NV_id == nv.id))
            {
                tongThoiGian.Sub(lv.NgayBatDau, lv.NgayKetThuc);
            }
            return tongThoiGian.ToMonths();
        }

        private static int tinhThamNienGiangDay_id(HRMDB0Entities db, int NhanVien_id)
        {
            return tinhThamNienGiangDay(db, NhanVien_id);
        }
        private static int tinhThamNienGiangDay_nv(HRMDB0Entities db, NhanVien nv)
        {
            return tinhThamNienGiangDay(db, nv);
        }
        private static int tinhThamNienTaiTruong_id(HRMDB0Entities db, int NhanVien_id)
        {
            return tinhThamNienTaiTruong(db, NhanVien_id);
        }
        private static int tinhThamNienTaiTruong_nv(HRMDB0Entities db, NhanVien nv)
        {
            return tinhThamNienTaiTruong(db, nv);
        }

        public static int themQuanLyThuViec(string MaThuViec, string HoVaTen, DateTime ThoiGianBatDau, int? DonVi_id, int? ViTriCongTac_id)
        {
            using (var db = new HRMDBEntities())
            {
                
                    var tv = new nvQLThuViec
                    {
                        maThuViec = MaThuViec,
                        HoVaTen = HoVaTen,
                        ThoiGianBatDau = ThoiGianBatDau,
                        DonVi_id = DonVi_id,
                        ChucDanhChucVu_id = ViTriCongTac_id
                        //ThoiGianKetThuc = ThoiGianBatDau.AddDays(Convert.ToDouble(thuviec)),
                    };
             
                db.nvQLThuViec.Add(tv);
                db.SaveChanges();
                return tv.id;
            }
        }

        public static void ketThucNhanVienMoi(int[] NV_id)
        {
            using (var db = new HRMDBEntities())
            {
                db.SqlExecute(String.Format(@"
                    update NhanVien set laNVMoi=0
                    where id in ({0})", String.Join(",", NV_id)));
            }
        }

        public static void taoNhanVienMoi(string maHS, string maNV)
        {
            using (var db = new HRMDBEntities())
            {
                db.NhanViens.All.Add(new NhanVien
                {
                    MaHS = maHS, MaNV = maNV
                });
                db.SaveChanges();
            }
        }
        public static void taoNhanVienMoi_Ten(string maHS, string maNV, string HoTen)
        {
            taoNhanVienMoi(maHS, maNV);
            using (var db = new HRMDBEntities())
            {
                var nv = db.NhanViens.All.Single(n => n.MaNV == maNV);
                var syll = nv.nvSoYeuLyLiches.First();
                syll.HoVaTen = HoTen;
                db.Entry(syll).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
