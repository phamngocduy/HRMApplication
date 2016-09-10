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
    public class DanhHieuController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        //
        // GET: /DanhHieu/

        public ActionResult Index()
        {
            var danhhieu = db.DanhHieu.Include(d => d.NhanVien);
            return View(danhhieu.ToList());
        }

        //
        // GET: /DanhHieu/Details/5

        public ActionResult Details(int id = 0)
        {
            DanhHieu danhhieu = db.DanhHieu.Find(id);
            if (danhhieu == null)
            {
                return HttpNotFound();
            }
            return View(danhhieu);
        }

        //
        // GET: /DanhHieu/Create

        public ActionResult Create()
        {
            ViewBag.TenDanhHieu_id = new SelectList(db.dmDanhHieu, "id", "TenDanhHieu");
            ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV");
            return View();
        }

        //
        // POST: /DanhHieu/Create

        [HttpPost]
        public ActionResult Create(DanhHieu danhhieu)
        {
            if (ModelState.IsValid)
            {
                db.DanhHieu.Add(danhhieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TenDanhHieu_id = new SelectList(db.dmDanhHieu, "id", "TenDanhHieu", danhhieu.TenDanhHieu_id);
            ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", danhhieu.NV_id);
            return View(danhhieu);
        }

        //
        // GET: /DanhHieu/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DanhHieu danhhieu = db.DanhHieu.Find(id);
            if (danhhieu == null)
            {
                return HttpNotFound();
            }
            ViewBag.TenDanhHieu_id = new SelectList(db.dmDanhHieu, "id", "TenDanhHieu", danhhieu.TenDanhHieu_id);
            ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", danhhieu.NV_id);
            return View(danhhieu);
        }

        //
        // POST: /DanhHieu/Edit/5

        [HttpPost]
        public ActionResult Edit(DanhHieu danhhieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhhieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TenDanhHieu_id = new SelectList(db.dmDanhHieu, "id", "TenDanhHieu", danhhieu.TenDanhHieu_id);
            ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", danhhieu.NV_id);
            return View(danhhieu);
        }

        //
        // GET: /DanhHieu/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DanhHieu danhhieu = db.DanhHieu.Find(id);
            if (danhhieu == null)
            {
                return HttpNotFound();
            }
            return View(danhhieu);
        }

        //
        // POST: /DanhHieu/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhHieu danhhieu = db.DanhHieu.Find(id);
            db.DanhHieu.Remove(danhhieu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}