using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTinhLuong.Controllers
{
    public class LuongKhoanController : HoSoController
    {
        private string table = "nvLuongKhoan";

        public new ActionResult Index()
        {
            ViewBag.db = db;
            return View();
        }

        public new PartialViewResult EditP(int? NV_id, int? id)
        {
            return base.EditP(NV_id, id);
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

        [HttpPost]
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }
    }
}
