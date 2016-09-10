using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;


namespace HRM.QLTTNhanSu.Controllers
{
    public class BoiDuongChuyenMonController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult  Index( int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return PartialView(model != null ? model : new BoiDuongChuyenMon() { NV_id = id });
        }

        [HttpPost]
        public ActionResult Update(int? BD_id)
        {
            var model = BD_id.HasValue ? db.BoiDuongChuyenMon.Find(BD_id) : new BoiDuongChuyenMon();
            var prefix = String.Format("{0}", Request.Form["Prefix"]);
            TryUpdateModel(model, !BD_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!BD_id.HasValue) db.BoiDuongChuyenMon.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            else TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "BoiDuongChuyenMon" });
        }

        //[HttpPost]
        public ActionResult Delete(int id)
        {
            var model = db.BoiDuongChuyenMon.Find(id);
            db.BoiDuongChuyenMon.Remove(model);
            db.SaveChanges();
            TempData["Message"] = "CapNhatThanhCong";
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "BoiDuongChuyenMon" });
        }

        public ActionResult QLTapSuThuViec()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}