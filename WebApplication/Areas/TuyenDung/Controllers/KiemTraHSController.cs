using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;

namespace HRM.TuyenDung.Controllers
{
    public class KiemTraHSController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /KiemTraHS/

        public ActionResult Index()
        {
            var tdkiemtrahs = db.tdKiemTraH.Include(t => t.tdTTUngCuVien);
            return View(tdkiemtrahs.ToList());
        }

        ////
        //// GET: /KiemTraHS/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    tdKiemTraH tdkiemtrah = db.tdKiemTraH.Find(id);
        //    if (tdkiemtrah == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdkiemtrah);
        //}

        ////
        //// GET: /KiemTraHS/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /KiemTraHS/Create

        //[HttpPost]
        //public ActionResult Create(tdKiemTraH tdkiemtrah)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tdKiemTraH.Add(tdkiemtrah);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.UngVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen", tdkiemtrah.UngVien_id);
        //    return View(tdkiemtrah);
        //}

        //
        // GET: /KiemTraHS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tdKiemTraH tdkiemtrah = db.tdKiemTraH.Where(hs => hs.UngVien_id == id).First();
            if (tdkiemtrah == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = tdkiemtrah.id;
            ViewBag.UngVien_id = tdkiemtrah.UngVien_id;
            return View(tdkiemtrah);
        }

        //
        // POST: /KiemTraHS/Edit/5

        [HttpPost]
        public ActionResult Edit(tdKiemTraH tdkiemtrah)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdkiemtrah).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "TuyenDung");
            }
            return View(tdkiemtrah);
        }

        ////
        //// GET: /KiemTraHS/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdKiemTraH tdkiemtrah = db.tdKiemTraH.Find(id);
        //    if (tdkiemtrah == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdkiemtrah);
        //}

        ////
        //// POST: /KiemTraHS/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdKiemTraH tdkiemtrah = db.tdKiemTraH.Find(id);
        //    db.tdKiemTraH.Remove(tdkiemtrah);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}