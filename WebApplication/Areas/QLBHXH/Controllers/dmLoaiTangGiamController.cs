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
    public class dmLoaiTangGiamController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmLoaiTangGiam/

        public ActionResult Index()
        {
            return View(db.dmLoaiTangGiam.ToList());
        }

        //
        // GET: /dmLoaiTangGiam/Details/5

        public ActionResult Details(int id = 0)
        {
            dmLoaiTangGiam dmloaitanggiam = db.dmLoaiTangGiam.Find(id);
            if (dmloaitanggiam == null)
            {
                return HttpNotFound();
            }
            return View(dmloaitanggiam);
        }

        //
        // GET: /dmLoaiTangGiam/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /dmLoaiTangGiam/Create

        [HttpPost]
        public ActionResult Create(dmLoaiTangGiam dmloaitanggiam)
        {
            if (ModelState.IsValid)
            {
                db.dmLoaiTangGiam.Add(dmloaitanggiam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dmloaitanggiam);
        }

        //
        // GET: /dmLoaiTangGiam/Edit/5

        public ActionResult Edit(int id = 0)
        {
            dmLoaiTangGiam dmloaitanggiam = db.dmLoaiTangGiam.Find(id);
            if (dmloaitanggiam == null)
            {
                return HttpNotFound();
            }
            return View(dmloaitanggiam);
        }

        //
        // POST: /dmLoaiTangGiam/Edit/5

        [HttpPost]
        public ActionResult Edit(dmLoaiTangGiam dmloaitanggiam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmloaitanggiam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dmloaitanggiam);
        }

        //
        // GET: /dmLoaiTangGiam/Delete/5

        public ActionResult Delete(int id = 0)
        {
            dmLoaiTangGiam dmloaitanggiam = db.dmLoaiTangGiam.Find(id);
            if (dmloaitanggiam == null)
            {
                return HttpNotFound();
            }
            return View(dmloaitanggiam);
        }

        //
        // POST: /dmLoaiTangGiam/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmLoaiTangGiam dmloaitanggiam = db.dmLoaiTangGiam.Find(id);
            db.dmLoaiTangGiam.Remove(dmloaitanggiam);
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