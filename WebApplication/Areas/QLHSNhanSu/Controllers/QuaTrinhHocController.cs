using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using System.Web.Routing;


namespace HRM.QLTTNhanSu.Controllers
{
    public class QuaTrinhHocController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        //
        // GET: /QuaTrinhHoc/

        public PartialViewResult Index(int id)
        {
            ViewBag.id = id;
            var quatrinhhoc = db.QuaTrinhHoc.Include(q => q.NhanVien);
            return PartialView(db.QuaTrinhHoc.ToList());
        }

        //
        // GET: /QuaTrinhHoc/Details/5

        public PartialViewResult Details(int id)
        {
            QuaTrinhHoc quatrinhhoc = db.QuaTrinhHoc.Find(id);
            if (quatrinhhoc == null)
            {
                return PartialView();
            }
            return PartialView(quatrinhhoc);
        }

        //
        // GET: /QuaTrinhHoc/Create

        public ActionResult Create(int id)
        {
            QuaTrinhHoc qt = new QuaTrinhHoc() { NV_id = id };
            return View(qt);
        }

        //
        // POST: /QuaTrinhHoc/Create

        [HttpPost]
        public ActionResult Create(QuaTrinhHoc quatrinhhoc)
        {
            if (ModelState.IsValid)
            {
                db.QuaTrinhHoc.Add(quatrinhhoc);
                db.SaveChanges();
                return RedirectToAction("Index","QTHocTap", new RouteValueDictionary(new{Controller = "QuaTrinhHoc", Action = "Index", id = quatrinhhoc.NV_id})) ;
            }

            return View(quatrinhhoc);
        }

        //
        // GET: /QuaTrinhHoc/Edit/5

        public ActionResult Edit(int id = 0)
        {
            QuaTrinhHoc quatrinhhoc = db.QuaTrinhHoc.Find(id);
            if (quatrinhhoc == null)
            {
                return HttpNotFound();
            }
            return View(quatrinhhoc);
        }

        //
        // POST: /QuaTrinhHoc/Edit/5

        [HttpPost]
        public ActionResult Edit(QuaTrinhHoc quatrinhhoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quatrinhhoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quatrinhhoc);
        }

        //
        // GET: /QuaTrinhHoc/Delete/5

        public ActionResult Delete(int id = 0)
        {
            QuaTrinhHoc quatrinhhoc = db.QuaTrinhHoc.Find(id);
            if (quatrinhhoc == null)
            {
                return HttpNotFound();
            }
            return View(quatrinhhoc);
        }

        //
        // POST: /QuaTrinhHoc/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            QuaTrinhHoc quatrinhhoc = db.QuaTrinhHoc.Find(id);
            db.QuaTrinhHoc.Remove(quatrinhhoc);
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