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
    public class ThongTinUngTuyenController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /ThongTinUngTuyen/

        public ActionResult Index()
        {
            var tdthongtinungtuyens = db.tdThongTinUngTuyen.Include(t => t.tdTTUngCuVien);
            return View(tdthongtinungtuyens.ToList());
        }

        //
        // GET: /ThongTinUngTuyen/Details/5

        public ActionResult Details(int UngVien_id = 0)
        {
            tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Where(ut => ut.UngVien_id == UngVien_id).First();
            if (tdthongtinungtuyen == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = UngVien_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UngVien_id);
            return View(tdthongtinungtuyen);
        }

        //
        // GET: /ThongTinUngTuyen/Create

        public ActionResult Create(int UV_id)
        {
            tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Where(ut => ut.UngVien_id == UV_id).First();
            if (tdthongtinungtuyen == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = tdthongtinungtuyen.UngVien_id;
            ViewBag.Id = tdthongtinungtuyen.id;
            return View();
        }

        //
        // POST: /ThongTinUngTuyen/Create

        [HttpPost]
        public ActionResult Create(tdThongTinUngTuyen tdthongtinungtuyen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdthongtinungtuyen).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Thêm mới thành công.";
                //return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinUngTuyen", nat = "Edit", id = tdthongtinungtuyen.UngVien_id });
                return RedirectToAction("Index","TuyenDung");
            }
            return View(tdthongtinungtuyen);
        }

        //
        // GET: /ThongTinUngTuyen/Edit/5

        public ActionResult Edit(int UV_id)
        {
            tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Where(ut => ut.UngVien_id == UV_id).First();
            if (tdthongtinungtuyen == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = tdthongtinungtuyen.UngVien_id;
            ViewBag.Id = tdthongtinungtuyen.id;
            return View(tdthongtinungtuyen);
        }

        //
        // POST: /ThongTinUngTuyen/Edit/5

        [HttpPost]
        public ActionResult Edit(tdThongTinUngTuyen tdthongtinungtuyen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdthongtinungtuyen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinUngTuyen", nat = "Edit", id = tdthongtinungtuyen.UngVien_id });
            }
            return View(tdthongtinungtuyen);
        }

        ////
        //// GET: /ThongTinUngTuyen/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Find(id);
        //    if (tdthongtinungtuyen == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdthongtinungtuyen);
        //}

        ////
        //// POST: /ThongTinUngTuyen/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Find(id);
        //    db.tdThongTinUngTuyen.Remove(tdthongtinungtuyen);
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