using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Transactions;
using HRM.QLThinhGiang.Models;
using HRM.QLThinhGiang.Helpers;
namespace HRM.QLThinhGiang.Controllers
{
    public class NhanVienController : HoSo_Controller
    {
        private string table = "NhanVien";

        public PartialViewResult IndexP()
        {
            return base.IndexP(0);
        }

        public PartialViewResult CreateP()
        {
            return PartialView("Create");
        }

        public string CreateS(string MaNV, string HoVaTen)
        {
            using (var scope = new TransactionScope())
            {
                var result = base.CreateS(table);
                if (String.IsNullOrEmpty(result))
                {
                    var query = from nv in db.NhanVien
                                join syll in db.nvSoYeuLyLich on nv.id equals syll.NV_id
                                where nv.MaNV.Equals(MaNV)
                                select syll;
                    var nvSoYeuLyLich = query.Single();
                    nvSoYeuLyLich = db.nvSoYeuLyLich.Find(nvSoYeuLyLich.id);
                    nvSoYeuLyLich.HoVaTen = HoVaTen;
                    db.Entry(nvSoYeuLyLich).State = EntityState.Modified;
                    db.SaveChanges();
                    scope.Complete();
                    return String.Empty;
                }
                else return base.CreateS(table);
            }
        }
    }
}