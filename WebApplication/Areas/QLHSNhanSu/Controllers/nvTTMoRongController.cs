using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Controllers
{
    public class nvTTMoRongController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Create(int id)
        {
            var model = db.NhanViens.All.Find(id).nvTTMoRongs.SingleOrDefault();
            if (model == null)
            {
                model = new nvTTMoRong() { NV_id = id };
                db.nvTTMoRong.Add(model);
                db.SaveChanges();
            }
            return Edit(model.id);
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.nvTTMoRong.Find(id);
            ViewBag.DB = db;
            return PartialView("Edit", model);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Update(int NV_id)
        {
            var model = db.NhanViens.All.Find(NV_id).nvTTMoRongs.Single();
            ModelState.Clear();
            TryUpdateModel(model);
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            ViewBag.DB = db;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + NV_id, "HSNhanSu", new { tab = "nvTTMoRong" });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}