using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Dynamic;
using System.Collections.Generic;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Controllers
{
    public class nvQLTapSuController : Controller
    {
        HRMDBEntities db = new HRMDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(int NV_id, int[] CT_id)
        {
            ModelState.Clear();
            var models = db.nvQLTapSu.Where(ct => CT_id.Contains(ct.CT_id));
            foreach (var item in models)
                TryUpdateModel<nvQLTapSu>(item, String.Format("{0}.{1}", NV_id, item.CT_id));
            if (ModelState.IsValid)
            {
                foreach (var item in models)
                    db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            } else
                TempData["Message"] = "CapNhatKhongThanhCong";
            TempData["NV_id"] = NV_id;
            return RedirectToAction("Index", new { From = Request["From"], To = Request["To"], All = Request["All"] });
        }

        public ActionResult Insert(int CT_id)
        {
            var model = db.nvQTLamViec.Find(CT_id);
            if (model.nvQLTapSus.FirstOrDefault() == null)
            {
                db.nvQLTapSu.Add(new nvQLTapSu() { CT_id = CT_id });
                db.SaveChanges();
                TempData["Message"] = "CapNhatThanhCong";
            }
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTCongTac" });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
