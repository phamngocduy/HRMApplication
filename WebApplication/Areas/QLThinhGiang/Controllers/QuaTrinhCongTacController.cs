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
    public class QuaTrinhCongTacController : Controller
    {/*
        private HRMDBEntities db = new HRMDBEntities();

        //
        // GET: /QuaTrinhCongTac/

        public ActionResult Index(int id)
        {
            var quatrinhcongtac_truoc = db.nvQTCongTac.Where(q => q.NV_id == id).Include(q => q.NhanVien);
            return View(quatrinhcongtac_truoc.ToList());
        }

        //
        // GET: /QuaTrinhCongTac/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    QuaTrinhCongTac_Truoc quatrinhcongtac_truoc = db.QuaTrinhCongTac_Truoc.Find(id);
        //    if (quatrinhcongtac_truoc == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(quatrinhcongtac_truoc);
        //}

        //
        // GET: /QuaTrinhCongTac/Create

        public ActionResult Create(int id)
        {
            nvQTCongTac qtct = new nvQTCongTac() { NV_id = id };
          //  InitializeSelectList(qtct);
         //   ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV");
            return View(qtct);
        }

        //
        // POST: /QuaTrinhCongTac/Create

        [HttpPost]
        public ActionResult Create(nvQTCongTac quatrinhcongtac_truoc)
        {
            if (ModelState.IsValid)
            {
                db.Add(quatrinhcongtac_truoc);
                db.SaveChanges();
                return RedirectToAction("Index", "QuaTrinhCongTac", new RouteValueDictionary(
 new { controller = "QuaTrinhCongTac", action = "Index", Id = quatrinhcongtac_truoc.NV_id }));
            }

           // ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", quatrinhcongtac_truoc.NV_id);
            return View(quatrinhcongtac_truoc);
        }

        //
        // GET: /QuaTrinhCongTac/Edit/5

        public ActionResult Edit(int id)
        {
            nvQTCongTac quatrinhcongtac_truoc = db.nvQTCongTac.Find(id);
            if (quatrinhcongtac_truoc == null)
            {
                return HttpNotFound();
            }
         //   ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", quatrinhcongtac_truoc.NV_id);
            return View(quatrinhcongtac_truoc);
        }

        //
        // POST: /QuaTrinhCongTac/Edit/5

        [HttpPost]
        public ActionResult Edit(nvQTCongTac quatrinhcongtac_truoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quatrinhcongtac_truoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "QuaTrinhCongTac", new RouteValueDictionary(
    new { controller = "QuaTrinhCongTac", action = "Index", Id = quatrinhcongtac_truoc.NV_id }));
            }
        //    ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaNV", quatrinhcongtac_truoc.NV_id);
            return View(quatrinhcongtac_truoc);
        }

        //
        // GET: /QuaTrinhCongTac/Delete/5

        public ActionResult Delete(int id)
        {
            nvQTCongTac quatrinhcongtac_truoc = db.nvQTCongTac.Find(id);
            if (quatrinhcongtac_truoc == null)
            {
                return HttpNotFound();
            }
            return View(quatrinhcongtac_truoc);
        }

        //
        // POST: /QuaTrinhCongTac/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
        //    int nv_id;
            nvQTCongTac quatrinhcongtac_truoc = db.nvQTCongTac.Find(id);
      //      nv_id = quatrinhcongtac_truoc.NV_id;
            db.nvQTCongTac.Remove(quatrinhcongtac_truoc);
            db.SaveChanges();
            return RedirectToAction("Index", "QuaTrinhCongTac", new RouteValueDictionary(
  new { controller = "QuaTrinhCongTac", action = "Index", Id = quatrinhcongtac_truoc.NV_id })); //not yet
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
 */    
    }
}