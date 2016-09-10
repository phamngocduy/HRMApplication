using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class QTNghiNganHanController : HoSoController
    {
        private string table = "nvQTNghiNganHan";

        public new PartialViewResult EditP(int? CT_id, int? id)
        {
            ViewBag.db = db;
            ViewBag.CT_id = CT_id;
            return PartialView("Edit", id);
        }

        [HttpPost]
        public string CreateS()
        {
            return base.CreateS(table);
        }

        [HttpPost]
        public string UpdateS()
        {
            return base.UpdateS(table);
        }
    }
}
