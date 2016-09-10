using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
using System.Collections.Specialized;
namespace HRM.QLTTNhanSu.Controllers
{
    public class QLTapSuController : HoSoController
    {
        private string table = "nvQLTapSu";

        public ActionResult Index(bool all = false)
        {
            ViewBag.All = all;
            return base.Index(0);
        }

        [HttpPost]
        public string CreateS(int CT_id)
        {
            var form = new NameValueCollection();
            form.Add("CT_id", CT_id.ToString());
            return db.SqlCreate(table, form) ?? "Thực hiện thêm thành công!";
        }

        public PartialViewResult EditP(int? id)
        {
            ViewBag.db = db;
            return PartialView("Edit", id);
        }

        [HttpPost]
        public string UpdateS(int SoThang = 0)
        {
            if (SoThang == 0) return base.UpdateS(table);
            var form = new NameValueCollection(Request.Form);
            form.Add("ThoiGianDenHan", DateTime.Parse(form["ThoiGianBatDau"]).AddMonths(SoThang).ToShortDateString());
            return db.SqlUpdate(table, form);
        }

        [HttpPost]
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }
    }
}
