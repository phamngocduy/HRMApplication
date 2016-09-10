using System;
using System.Collections.Generic;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Models
{
    public static class TaiNguyenExt
    {
        public static void Include(this TaiNguyen tainguyen, HRMDBEntities context)
        {
            tainguyen.chaTaiNguyen = context.TaiNguyen.Find(tainguyen.idTaiNguyen);
        }

        public static TaiNguyen getParent(this TaiNguyen tainguyen)
        {
            return tainguyen.chaTaiNguyen;
        }

        public static string getFolder(this TaiNguyen tainguyen)
        {
            var path = tainguyen.getParent() == null ? "." : tainguyen.getParent().getFolder();
            return tainguyen.laThuMuc ? path + "/" + tainguyen.tenTaiNguyen : path;
        }

        public static ICollection<TaiNguyen> getChildren(this TaiNguyen tainguyen)
        {
            return tainguyen.TaiNguyen1;
        }
    }
}