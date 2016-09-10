using System;
using System.Linq;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Models
{
    public static class nvSoYeuLyLichExt
    {
        public static DiaPhuong getNoiSinh(this nvSoYeuLyLich model, HRMDBEntities db)
        {
            var obj = db.DiaPhuong.Find(model.NoiSinh_id);
            return obj != null ? obj : new DiaPhuong();
        }

        public static DiaPhuong getQueQuan(this nvSoYeuLyLich model, HRMDBEntities db)
        {
            var obj = db.DiaPhuong.Find(model.QueQuan_id);
            return obj != null ? obj : new DiaPhuong();
        }
    }
}