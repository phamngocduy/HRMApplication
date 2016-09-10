using System;
using System.Reflection;
using System.Collections.Generic;

using HRM.Databases.Models;
namespace HRM.Services
{
    public class QLTTNhanSu : Services
    {
        private static Type Library = null;
        public static void LoadServices()
        {
            Library = LoadServices("HRM.QLHSNhanSu.dll", // library
                                    "HRM.QLTTNhanSu.Services.QLTTNhanSuServices");
        }

        public static int tinhThamNienGiangDay(HRMDB0Entities db, int NhanVien_id)
        {
            return (int)LoadMethod(Library, "tinhThamNienGiangDay_id")
                .Invoke(null, new object[]
                {
                    db, NhanVien_id
                });
        }
        public static int tinhThamNienGiangDay(HRMDB0Entities db, NhanVien nv)
        {
            return (int)LoadMethod(Library, "tinhThamNienGiangDay_nv")
                .Invoke(null, new object[]
                {
                    db, nv
                });
        }

        public static int tinhThamNienTaiTruong(HRMDB0Entities db, int NhanVien_id)
        {
            return (int)LoadMethod(Library, "tinhThamNienTaiTruong")
                .Invoke(null, new object[]
                {
                    db, NhanVien_id
                });
        }
        public static int tinhThamNienTaiTruong(HRMDB0Entities db, NhanVien nv)
        {
            return (int)LoadMethod(Library, "tinhThamNienTaiTruong")
                .Invoke(null, new object[]
                {
                    db, nv
                });
        }

        public static int themQuanLyThuViec(string MaThuViec, string HoVaTen, DateTime ThoiGianBatDau, int? DonVi_id, int? ViTriCongTac_id)
        {
            return (int)LoadMethod(Library, "themQuanLyThuViec")
                .Invoke(null, new object[]
                {
                    MaThuViec, HoVaTen, ThoiGianBatDau, DonVi_id, ViTriCongTac_id
                });
        }

        public static void ketThucNhanVienMoi(int[] NV_id)
        {
            LoadMethod(Library, "ketThucNhanVienMoi")
                .Invoke(null, new object[] { NV_id });
        }

        public static void taoNhanVienMoi(string maHS, string maNV)
        {
            LoadMethod(Library, "taoNhanVienMoi")
                .Invoke(null, new object[] { maHS, maNV });
        }
        public static void taoNhanVienMoi_Ten(string maHS, string maNV, string HoTen)
        {
            LoadMethod(Library, "taoNhanVienMoi_Ten")
                .Invoke(null, new object[] { maHS, maNV, HoTen });
        }
    }
}
