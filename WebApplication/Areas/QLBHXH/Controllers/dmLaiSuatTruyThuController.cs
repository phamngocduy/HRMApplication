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
    public class dmLaiSuatTruyThuController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmLaiSuatTruyThu/

        public ActionResult Index()
        {
            return View(db.dmLaiSuatTruyThu.ToList());
        }

        //
        // GET: /dmLaiSuatTruyThu/Details/5

        public ActionResult Details(int id = 0)
        {
            dmLaiSuatTruyThu dmlaisuattruythu = db.dmLaiSuatTruyThu.Find(id);
            if (dmlaisuattruythu == null)
            {
                return HttpNotFound();
            }
            return View(dmlaisuattruythu);
        }

        //
        // GET: /dmLaiSuatTruyThu/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /dmLaiSuatTruyThu/Create

        [HttpPost]
        public ActionResult Create(dmLaiSuatTruyThu dmlaisuattruythu)
        {
            if (ModelState.IsValid)
            {
                db.dmLaiSuatTruyThu.Add(dmlaisuattruythu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dmlaisuattruythu);
        }

        //
        // GET: /dmLaiSuatTruyThu/Edit/5

        public ActionResult Edit(int id = 0)
        {
            dmLaiSuatTruyThu dmlaisuattruythu = db.dmLaiSuatTruyThu.Find(id);
            if (dmlaisuattruythu == null)
            {
                return HttpNotFound();
            }
            return View(dmlaisuattruythu);
        }

        //
        // POST: /dmLaiSuatTruyThu/Edit/5

        [HttpPost]
        public ActionResult Edit(dmLaiSuatTruyThu dmlaisuattruythu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmlaisuattruythu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dmlaisuattruythu);
        }

        //
        // GET: /dmLaiSuatTruyThu/Delete/5

        public ActionResult Delete(int id = 0)
        {
            dmLaiSuatTruyThu dmlaisuattruythu = db.dmLaiSuatTruyThu.Find(id);
            if (dmlaisuattruythu == null)
            {
                return HttpNotFound();
            }
            return View(dmlaisuattruythu);
        }

        //
        // POST: /dmLaiSuatTruyThu/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmLaiSuatTruyThu dmlaisuattruythu = db.dmLaiSuatTruyThu.Find(id);
            db.dmLaiSuatTruyThu.Remove(dmlaisuattruythu);
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