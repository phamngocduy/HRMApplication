using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;


namespace HRM.HDLaoDong.Controllers
{
    public class DSNLDCanTaoHDController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /DSNLDCanTaoHD/

        public ActionResult Index()
        {
            return View(db.hdCanTaoHDLD.ToList());
        }


        //
        // GET: /DSNLDCanTaoHD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DSNLDCanTaoHD/Create

        [HttpPost]
        public ActionResult Create(hdCanTaoHDLD hdcantaohdld)
        {
            if (ModelState.IsValid)
            {
                db.hdCanTaoHDLD.Add(hdcantaohdld);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hdcantaohdld);
        }



        //
        // GET: /DSNLDCanTaoHD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            hdCanTaoHDLD hdcantaohdld = db.hdCanTaoHDLD.Find(id);
            if (hdcantaohdld == null)
            {
                return HttpNotFound();
            }
            return View(hdcantaohdld);
        }

        //
        // POST: /DSNLDCanTaoHD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            hdCanTaoHDLD hdcantaohdld = db.hdCanTaoHDLD.Find(id);
            db.hdCanTaoHDLD.Remove(hdcantaohdld);
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