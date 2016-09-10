using System;
using System.Linq;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Models
{
    public static class nvTTCoBanExt
    {
        public static dmTinhThanh getNoiSinh(this nvTTCoBan nvttcoban)
        {
            using (var context = new HRMDBEntities())
                return context.dmTinhThanh.Find(nvttcoban.NoiSinh_id);
        }

        public static dmTinhThanh getQueQuan(this nvTTCoBan nvttcoban)
        {
            using (var context = new HRMDBEntities())
                return context.dmTinhThanh.Find(nvttcoban.QueQuan_id);
        }
    }
}