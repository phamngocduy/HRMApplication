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
    public class dmLoaiDieuChinhController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmLoaiDieuChinh/

        public ActionResult Index()
        {
            var dmloaidieuchinhs = db.dmLoaiDieuChinh;
            return View(dmloaidieuchinhs.ToList());
        }

        //
        // GET: /dmLoaiDieuChinh/Details/5

        public ActionResult Details(int id = 0)
        {
            dmLoaiDieuChinh dmloaidieuchinh = db.dmLoaiDieuChinh.Find(id);
            if (dmloaidieuchinh == null)
            {
                return HttpNotFound();
            }
            return View(dmloaidieuchinh);
        }

        //
        // GET: /dmLoaiDieuChinh/Create

        public ActionResult Create(int id = 0)
        {
            var lgt = (from m in db.dmLoaiTangGiam select m.id).First();
            ViewBag.lgt = lgt;
            ViewBag.idLoaiTangGiam = new SelectList(db.dmLoaiTangGiam, "id", "LoaiTangGiam");
            return View();
        }

        //
        // POST: /dmLoaiDieuChinh/Create

        [HttpPost]
        public ActionResult Create(dmLoaiDieuChinh dmloaidieuchinh)
        {
            if (ModelState.IsValid)
            {
                db.dmLoaiDieuChinh.Add(dmloaidieuchinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idLoaiTangGiam = new SelectList(db.dmLoaiTangGiam, "id", "Ma", dmloaidieuchinh);
            return View(dmloaidieuchinh);
        }

        //
        // GET: /dmLoaiDieuChinh/Edit/5

        public ActionResult Edit(int id = 0)
        {
            dmLoaiDieuChinh dmloaidieuchinh = db.dmLoaiDieuChinh.Find(id);
            if (dmloaidieuchinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLoaiTangGiam = new SelectList(db.dmLoaiTangGiam, "id", "Ma", dmloaidieuchinh);
            return View(dmloaidieuchinh);
        }

        //
        // POST: /dmLoaiDieuChinh/Edit/5

        [HttpPost]
        public ActionResult Edit(dmLoaiDieuChinh dmloaidieuchinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmloaidieuchinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idLoaiTangGiam = new SelectList(db.dmLoaiTangGiam, "id", "Ma", dmloaidieuchinh);
            return View(dmloaidieuchinh);
        }

        //
        // GET: /dmLoaiDieuChinh/Delete/5

        public ActionResult Delete(int id = 0)
        {
            dmLoaiDieuChinh dmloaidieuchinh = db.dmLoaiDieuChinh.Find(id);
            if (dmloaidieuchinh == null)
            {
                return HttpNotFound();
            }
            return View(dmloaidieuchinh);
        }

        //
        // POST: /dmLoaiDieuChinh/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmLoaiDieuChinh dmloaidieuchinh = db.dmLoaiDieuChinh.Find(id);
            db.dmLoaiDieuChinh.Remove(dmloaidieuchinh);
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