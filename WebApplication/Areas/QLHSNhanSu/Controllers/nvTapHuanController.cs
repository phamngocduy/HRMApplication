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
    public class nvTapHuanController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return PartialView(model != null ? model : new nvTapHuan(){NV_id=id});
        }
        [HttpPost]
        public ActionResult Update(int? nvTH_id)
        {
            var model = nvTH_id.HasValue ? db.nvTapHuan.Find(nvTH_id) : new nvTapHuan();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !nvTH_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!nvTH_id.HasValue) db.nvTapHuan.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            else TempData ["Model"] = model;
            TempData ["ModelState"] = ModelState;
            return RedirectToAction ("Details/" + model.NV_id, "HSNhanSu", new { tab = "SoTayCT"});
          }
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            var model = db.nvTapHuan.Find(id);
            db.nvTapHuan.Remove(model);
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