using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Transactions;
using HRM.Databases.Models;
using HRM.Webpages.Helpers;
using HRM.Services;
namespace HRM.QLTTNhanSu.Controllers
{
    public class NhanVienController : HoSoController
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
                }
                else return base.CreateS(table);
            }
            try
            {
                Extension.SendMessage("*", String.Format("Tạo mới CB/GV/NV {0} vào ngày {1}.", HoVaTen, DateTime.Now.ToShortDateString()));
            }
            catch (Exception e) { return String.Format("Tạo mới thành công! [{0}]", e.Message); }
            return String.Empty;
        }
    }
}