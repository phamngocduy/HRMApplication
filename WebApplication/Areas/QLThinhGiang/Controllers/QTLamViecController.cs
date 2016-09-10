using System;
using System.Web.Mvc;
using HRM.QLThinhGiang.Helpers;
namespace HRM.QLThinhGiang.Controllers
{
    public class QTLamViecController : HoSo_Controller
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