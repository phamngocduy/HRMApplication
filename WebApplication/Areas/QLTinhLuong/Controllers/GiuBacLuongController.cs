using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTinhLuong.Controllers
{
    public class GiuBacLuongController : HoSoController
    {
        private string table = "nvGiuBacLuong";

        public new PartialViewResult EditP(int? HSL_id, int? id)
        {
            ViewBag.db = db;
            ViewBag.HSL_id = HSL_id;
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