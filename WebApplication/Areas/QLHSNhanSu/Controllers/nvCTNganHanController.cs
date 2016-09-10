using System;
using System.Data;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Controllers
{
    public class nvCTNganHanController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return PartialView(model != null ? model : new nvCTNganHan() { NV_id = id });
        }

        [HttpPost]
        public ActionResult Update(int? CT_id)
        {
            var model = CT_id.HasValue ? db.nvCTNganHan.Find(CT_id) : new nvCTNganHan();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !CT_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!CT_id.HasValue) db.nvCTNganHan.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            else TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "SoTayCT" });
        }

        //[HttpPost]
        public ActionResult Delete(int id)
        {
            var model = db.nvCTNganHan.Find(id);
            db.nvCTNganHan.Remove(model);
            db.SaveChanges();
            TempData["Message"] = "CapNhatThanhCong";
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "SoTayCT" });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}