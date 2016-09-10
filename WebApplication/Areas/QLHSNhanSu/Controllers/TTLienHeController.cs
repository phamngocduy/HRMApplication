using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class TTLienHeController : HoSoController
    {
        private string table = "NhanVien";

        public PartialViewResult EditP(int? id)
        {
            return base.EditP(0, id);
        }

        [HttpPost]
        public ActionResult Update()
        {
            return base.Update(table);
        }
    }
}