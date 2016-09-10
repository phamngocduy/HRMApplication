using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using System.Web.Routing;

namespace HRM.QLTTNhanSu.Controllers
{
    public class TapHuanController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return PartialView(model != null ? model : new TapHuan());
        }
        [HttpPost]
        public ActionResult Update(int? TH_id)
        {
            var model = TH_id.HasValue ? db.TapHuan.Find(TH_id) : new TapHuan();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !TH_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!TH_id.HasValue) db.TapHuan.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            else TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.id, "HSNhanSu", new { tab = "SoTayCT" });
        }
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            var model = db.TapHuan.Find(id);
            db.TapHuan.Remove(model);
            db.SaveChanges();
            TempData["Message"] = "CapNhatThanhCong";
            return RedirectToAction("Details/" + model.id, "HSNhanSu", new { tab = "SoTayCT" });
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}