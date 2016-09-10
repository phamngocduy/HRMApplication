using System;
using System.Web;
using System.Reflection;

using HRM.Databases.Models;
namespace HRM.Services
{
    public class QLDanhMuc : Services
    {
        private static Type Library = null;
        public static void LoadServices()
        {
            Library = LoadServices("HRM.QLDanhMuc.dll", // library
                                    "HRM.QLDanhMuc.Services.QLDanhMucServices");
        }

        public static string getDuongDanTapTin(HttpServerUtilityBase server, HRMDB0Entities db, int TaiNguyen_id)
        {
            return LoadMethod(Library, "getDuongDanTapTin")
                .Invoke(null, new object[]
                {
                    server, db, TaiNguyen_id
                }) as string;
        }
    }
}
