using System;
using System.IO;
using System.Web;

using HRM.Databases.Models;
using HRM.QLDanhMuc.Models;
namespace HRM.QLDanhMuc.Services
{
    public class QLDanhMucServices
    {
        private static string App_Root = @"~/App_Data/UPLOADS";
        public static string getDuongDanTapTin(HttpServerUtilityBase server, HRMDB0Entities db, int TaiNguyen_id)
        {
            var tn = db.TaiNguyen.Find(TaiNguyen_id);
            if (tn == null || tn.laThuMuc) return String.Empty;
            return Path.Combine(server.MapPath(App_Root), tn.getFolder(), tn.tepDinhKem);
        }
    }
}
