using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLBHXH.Models;


namespace HRM.QLBHXH.Controllers
{
    public class DSLaiTruyThuBHController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /DSLaiTruyThuBH/

        public ActionResult Index()
        {
            var nvbhlaitruythubhs = db.nvbhLaiTruyThuBH.Include(n => n.dmLaiSuatTruyThu).Include(n => n.dmMucLuongToiThieuChung).Include(n => n.dmTyLeDongBHXH).Include(n => n.nvbhNhanVienBHXH);
            return View(nvbhlaitruythubhs.ToList());
        }

        public ActionResult Index2()
        {
            var nvbhlaitruythubhs = db.nvbhLaiTruyThuBH.Include(n => n.dmLaiSuatTruyThu).Include(n => n.dmMucLuongToiThieuChung).Include(n => n.dmTyLeDongBHXH).Include(n => n.nvbhNhanVienBHXH);
            return View(nvbhlaitruythubhs.ToList());
        }
        //
        // GET: /DSLaiTruyThuBH/Details/5

        public ActionResult Details(int id = 0)
        {
            nvbhLaiTruyThuBH nvbhlaitruythubh = db.nvbhLaiTruyThuBH.Find(id);
            if (nvbhlaitruythubh == null)
            {
                return HttpNotFound();
            }
            return View(nvbhlaitruythubh);
        }

        //
        // GET: /DSLaiTruyThuBH/Create

        public PartialViewResult Create()
        {
            ViewBag.iddmLaiSuatTruyThu = new SelectList(db.dmLaiSuatTruyThu, "id", "NgayApDung");
            ViewBag.iddmMucLuongToiThieuChung = new SelectList(db.dmMucLuongToiThieuChung, "id", "NgayBatDau");
            ViewBag.iddmTyLeDongBHXH = new SelectList(db.dmTyLeDongBHXH, "id", "NgayApDung");
            ViewBag.idnvbhNhanVienBHXH = new SelectList((from nv in db.nvbhNhanVienBHXH select new { id = nv.id, HoVaTen = nv.HoVaTen + " - " + nv.MANV }), "id", "HoVaTen");

            return PartialView();
        }

        //
        // POST: /DSLaiTruyThuBH/Create

        [HttpPost]
        public ActionResult Create(nvbhLaiTruyThuBH nvbhlaitruythubh)
        {
            if (ModelState.IsValid)
            {
                db.nvbhLaiTruyThuBH.Add(nvbhlaitruythubh);
                db.SaveChanges();
                return RedirectToAction("Index2");
            }

            ViewBag.iddmLaiSuatTruyThu = new SelectList(db.dmLaiSuatTruyThu, "id", "id", nvbhlaitruythubh.iddmLaiSuatTruyThu);
            ViewBag.iddmMucLuongToiThieuChung = new SelectList(db.dmMucLuongToiThieuChung, "id", "GhiChu", nvbhlaitruythubh.iddmMucLuongToiThieuChung);
            ViewBag.iddmTyLeDongBHXH = new SelectList(db.dmTyLeDongBHXH, "id", "DoanhNghiepBHXH", nvbhlaitruythubh.iddmTyLeDongBHXH);
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhlaitruythubh.idnvbhNhanVienBHXH);

            return View(nvbhlaitruythubh);
        }

        //
        // GET: /DSLaiTruyThuBH/Edit/5

        public PartialViewResult Edit(int id = 0)
        {
            nvbhLaiTruyThuBH nvbhlaitruythubh = db.nvbhLaiTruyThuBH.Find(id);
            //if (nvbhlaitruythubh == null)
            //{
            //    return HttpNotFound();
            //}
            ViewBag.iddmLaiSuatTruyThu = new SelectList(db.dmLaiSuatTruyThu, "id", "NgayApDung", nvbhlaitruythubh.iddmLaiSuatTruyThu);
            ViewBag.iddmMucLuongToiThieuChung = new SelectList(db.dmMucLuongToiThieuChung, "id", "NgayBatDau", nvbhlaitruythubh.iddmMucLuongToiThieuChung);
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhlaitruythubh.idnvbhNhanVienBHXH);
            ViewBag.iddmTyLeDongBHXH = new SelectList(db.dmTyLeDongBHXH, "id", "NgayApDung", nvbhlaitruythubh.iddmTyLeDongBHXH);
            return PartialView(nvbhlaitruythubh);
        }

        //
        // POST: /DSLaiTruyThuBH/Edit/5

        [HttpPost]
        public ActionResult Edit(nvbhLaiTruyThuBH nvbhlaitruythubh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvbhlaitruythubh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index2");
            }
            ViewBag.iddmLaiSuatTruyThu = new SelectList(db.dmLaiSuatTruyThu, "id", "id", nvbhlaitruythubh.iddmLaiSuatTruyThu);
            ViewBag.iddmMucLuongToiThieuChung = new SelectList(db.dmMucLuongToiThieuChung, "id", "GhiChu", nvbhlaitruythubh.iddmMucLuongToiThieuChung);
            ViewBag.iddmTyLeDongBHXH = new SelectList(db.dmTyLeDongBHXH, "id", "DoanhNghiepBHXH", nvbhlaitruythubh.iddmTyLeDongBHXH);
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhlaitruythubh.idnvbhNhanVienBHXH);
            return View(nvbhlaitruythubh);
        }

        //
        // GET: /DSLaiTruyThuBH/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            nvbhLaiTruyThuBH nvbhlaitruythubh = db.nvbhLaiTruyThuBH.Find(id);
            //if (nvbhlaitruythubh == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhlaitruythubh);
        }

        //
        // POST: /DSLaiTruyThuBH/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            nvbhLaiTruyThuBH nvbhlaitruythubh = db.nvbhLaiTruyThuBH.Find(id);
            db.nvbhLaiTruyThuBH.Remove(nvbhlaitruythubh);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}