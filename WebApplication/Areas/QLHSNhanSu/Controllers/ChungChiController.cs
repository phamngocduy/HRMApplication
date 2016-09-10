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
    public class ChungChiController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return PartialView(model != null ? model : new ChungChi() { NV_id = id });

        }
        [HttpPost]
        public ActionResult Update(int? CC_id)
        {
            var model = CC_id.HasValue ? db.ChungChi.Find(CC_id) : new ChungChi();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !CC_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!CC_id.HasValue) db.ChungChi.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            else TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        }
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            var model = db.ChungChi.Find(id);
            db.ChungChi.Remove(model);
            db.SaveChanges();
            try
            {
                nvQTChungChi ht = db.nvQTChungChi.Find(model.HoTro);
                int tmp = 0;
                tmp = db.nvQTChungChi.Where(m => m.id == model.HoTro).Select(m => m.id).FirstOrDefault();
                if (tmp != 0)
                {

                    ht.ThoiGianKetThucChinhThuc = null;
                    db.SaveChanges();

                }

            }
            catch
            {
            }
            TempData["Message"] = "CapNhatThanhCong";
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new  { tab = "QTHocTap" });
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}