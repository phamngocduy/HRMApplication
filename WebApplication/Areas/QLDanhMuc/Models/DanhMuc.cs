using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Models
{
    public class DanhMuc
    {
        public DanhMuc() { }
        public DanhMuc(string name, object model)
        {
            var type = model.GetType();
            id = (int)type.GetProperty("id").GetValue(model, null);
            stt = (Nullable<int>)type.GetProperty("stt").GetValue(model, null);
            maDanhMuc = type.GetProperty("ma" + name).GetValue(model, null) as string;
            tenDanhMuc = type.GetProperty("ten" + name).GetValue(model, null) as string;
        }
        [Required]
        public int id { get; set; }
        [Range(1, int.MaxValue)]
        public Nullable<int> stt { get; set; }
        public string maDanhMuc { get; set; }
        [Required]
        public string tenDanhMuc { get; set; }
    }

    public static class DanhMucExt
    {
        public static IEnumerable<string> listDanhMuc(this HRMDBEntities db)
        {
            var list = new List<string>();
            foreach (var property in TypeDescriptor.GetProperties(db))
                list.Add((property as PropertyDescriptor).Name);
            return list.Where(name => name.StartsWith("dm"));
        }

        private static int id(this object obj)
        {
            return (int)obj.GetType().GetProperty("id").GetValue(obj, null);
        }
        private static Nullable<int> stt(this object obj)
        {
            return (Nullable<int>)obj.GetType().GetProperty("stt").GetValue(obj, null);
        }
        private static void stt(this object obj, int val)
        {
            obj.GetType().GetProperty("stt").SetValue(obj, val, null);
        }
        private static int CompareTo(this object dm1, object dm2)
        {
            int? a = dm1.stt(), b = dm2.stt();
            if (!a.HasValue && !b.HasValue)
                return dm1.id().CompareTo(dm2.id());
            if (!a.HasValue) a = int.MaxValue;
            if (!b.HasValue) b = int.MaxValue;
            return a.Value.CompareTo(b.Value);
        }
        public static void updateSTT(this HRMDBEntities db, string name, int start)
        {
            var dbset = db.GetType().GetProperty("dm" + name).GetValue(db, null) as IEnumerable<object>;
            dbset.Where(dm => dm.stt() >= start).ToList().ForEach(
                dm =>
                {
                    dm.stt(dm.stt().Value + 1);
                    db.Entry(dm).State = EntityState.Modified;
                });
        }

        public static IEnumerable<DanhMuc> loadDanhMuc(this HRMDBEntities db, string name)
        {
            var dbset = db.GetType().GetProperty("dm" + name).GetValue(db, null);
            var list = (dbset as IEnumerable<object>).ToList();
            list.Sort(new Comparison<object>((o1, o2) => o1.CompareTo(o2)));
            for (int i=0, c=1; i<list.Count; i++, c++)
                if (list[i].stt() != c)
                {
                    list[i].stt(c);
                    db.Entry(list[i]).State = EntityState.Modified;
                }
            db.SaveChanges();
            return (from dm in list select new DanhMuc(name, dm)).ToList();
        }

        public static object findDanhMuc(this HRMDBEntities db, string name, int id)
        {
            var dbset = db.GetType().GetProperty("dm" + name).GetValue(db, null);
            return dbset.GetType().GetMethod("Find").Invoke(dbset, new object[] { new object[] { id } });
        }

        public static object makeDanhMuc(this HRMDBEntities db, string name, DanhMuc model)
        {
            var danhmuc = Activator.CreateInstance("HRM.Databases", "HRM.Databases.Models.dm" + name).Unwrap();
            danhmuc.GetType().GetProperty("stt").SetValue(danhmuc, model.stt, null);
            danhmuc.GetType().GetProperty("ma" + name).SetValue(danhmuc, model.maDanhMuc, null);
            danhmuc.GetType().GetProperty("ten" + name).SetValue(danhmuc, model.tenDanhMuc, null);
            return danhmuc;
        }
    }
}