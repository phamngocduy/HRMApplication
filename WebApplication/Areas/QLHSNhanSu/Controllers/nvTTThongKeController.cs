using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Transactions;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Controllers
{
    public class nvTTThongKeController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Create(int id)
        {
            var model = db.NhanViens.All.Find(id).nvTTThongKes.SingleOrDefault();
            if (model == null)
            {
                model = new nvTTThongKe() { NV_id = id };
                db.nvTTThongKe.Add(model);
                db.SaveChanges();
            }
            return Edit(model.id);
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.nvTTThongKe.Find(id);
            return PartialView("Edit", model);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Update(int NV_id, int[] KhoaGiangDay, int[] NganhGiangDay)
        {
            var model = db.NhanViens.All.Find(NV_id).nvTTThongKes.Single();
            ModelState.Clear();
            TryUpdateModel(model);
            if (ModelState.IsValid)
                using (var scope = new TransactionScope())
                {
                    db.Entry(model).State = EntityState.Modified;
                    // khoa giang day
                    db.SaveChanges();
                    model.NhanVien.nvKhoaGiangDays.ToList().ForEach(kgd => db.nvKhoaGiangDay.Remove(kgd));
                    db.SaveChanges();
                    if (KhoaGiangDay != null)
                        KhoaGiangDay.ToList().ForEach(id => db.nvKhoaGiangDay.Add(new nvKhoaGiangDay { NV_id = model.NV_id, KhoaGiangDay = id}));
                    db.SaveChanges();
                    // nganh giang day
                    model.NhanVien.nvNganhGiangDays.ToList().ForEach(ngd => db.nvNganhGiangDay.Remove(ngd));
                    db.SaveChanges();
                    if (NganhGiangDay != null)
                        NganhGiangDay.ToList().ForEach(id => db.nvNganhGiangDay.Add(new nvNganhGiangDay { NV_id = model.NV_id, NganhGiangDay = id }));
                    db.SaveChanges();
                    scope.Complete();
                    TempData["Controller"] = "nvTTThongKe";
                    TempData["Message"] = "CapNhatThanhCong";
                }
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + NV_id, "HSNhanSu", new { tab = "QTCongTac" });
        }

        public ActionResult Import()
        {
            var temp = Server.MapPath(@"~/App_Data/TEMP");
            if (!Directory.Exists(temp))
                Directory.CreateDirectory(temp);
            ViewBag.File = Path.Combine(temp, Request.Files[0].FileName);
            Request.Files[0].SaveAs(ViewBag.File);
            return View();
        }

        public ActionResult Export()
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