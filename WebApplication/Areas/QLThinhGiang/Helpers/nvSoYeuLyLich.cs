using System;
using System.Linq;

using HRM.Databases.Models;
namespace HRM.QLThinhGiang.Models
{
    public static class nvSoYeuLyLichExt
    {
        public static HRM.Databases.Models.DiaPhuong getNoiSinh(this nvSoYeuLyLich model, HRMDB0Entities db)
        {
            var obj = db.DiaPhuong.Find(model.NoiSinh_id);
            return obj != null ? obj : new HRM.Databases.Models.DiaPhuong();
        }

        public static HRM.Databases.Models.DiaPhuong getQueQuan(this nvSoYeuLyLich model, HRMDB0Entities db)
        {
            var obj = db.DiaPhuong.Find(model.QueQuan_id);
            return obj != null ? obj : new HRM.Databases.Models.DiaPhuong();
        }
    }
}