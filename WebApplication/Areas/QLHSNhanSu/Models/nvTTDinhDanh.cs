using System;
using System.Linq;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Models
{
    public static class nvTTDinhDanhExt
    {
        public static dmQuocGia getQuocTich(this nvTTDinhDanh nvttdinhdanh)
        {
            using (var context = new HRMDBEntities())
                return context.dmQuocGia.Find(nvttdinhdanh.QuocTich_id);
        }

        public static dmQuocGia getQuocTich2(this nvTTDinhDanh nvttdinhdanh)
        {
            using (var context = new HRMDBEntities())
                return context.dmQuocGia.Find(nvttdinhdanh.QuocTich2_id);
        }

        public static nvTheDinhDanh getCMND(this nvTTDinhDanh nvttdinhdanh)
        {
            using (var context = new HRMDBEntities())
                return context.nvTheDinhDanh.Find(nvttdinhdanh.CMND_id);
        }

        public static nvTheDinhDanh getHoChieu(this nvTTDinhDanh nvttdinhdanh)
        {
            using (var context = new HRMDBEntities())
                return context.nvTheDinhDanh.Find(nvttdinhdanh.HoChieu_id);
        }

        public static nvTheDinhDanh getTheSiQuan(this nvTTDinhDanh nvttdinhdanh)
        {
            using (var context = new HRMDBEntities())
                return context.nvTheDinhDanh.Find(nvttdinhdanh.TheSiQuan_id);
        }
    }
}