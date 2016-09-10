using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLVayMuon.Models;

namespace HRM.QLVayMuon.Controllers
{
    public class dmMucDichSuDungController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmMucDichSuDung/

        public ActionResult Index()
        {
            var model = (from MD in db.dmMucDichSuDung
                         orderby MD.stt
                         select MD).ToList();
            for (int i = 0, c = 1; i < model.Count; i++, c++)
                if (model[i].stt != c)
                {
                    model[i].stt = c;
                    db.Entry(model[i]).State = EntityState.Modified;
                }
            db.SaveChanges();

            return View(db.dmMucDichSuDung.ToList());
        }

        //
        // GET: /dmMucDichSuDung/Details/5

        public ActionResult Details(int id = 0)
        {
            dmMucDichSuDung dmmucdichsudung = db.dmMucDichSuDung.Find(id);
            if (dmmucdichsudung == null)
            {
                return HttpNotFound();
            }
            return View(dmmucdichsudung);
        }

        //
        // GET: /dmMucDichSuDung/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /dmMucDichSuDung/Create

        [HttpPost]
        public ActionResult Create(dmMucDichSuDung dmmucdichsudung)
        {
            if (ModelState.IsValid)
            {
                db.dmMucDichSuDung.Add(dmmucdichsudung);
                db.SaveChanges();
                TempData["Message"] = "Thêm Mục đích sử dụng thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Thêm Mục đích sử dụng không thành công";
                return RedirectToAction("Index");
            }

            return View(dmmucdichsudung);
        }

        //
        // GET: /dmMucDichSuDung/Edit/5

        public ActionResult Edit(int id = 0)
        {
            dmMucDichSuDung dmmucdichsudung = db.dmMucDichSuDung.Find(id);
            if (dmmucdichsudung == null)
            {
                return HttpNotFound();
            }
            return View(dmmucdichsudung);
        }

        //
        // POST: /dmMucDichSuDung/Edit/5

        [HttpPost]
        public ActionResult Edit(dmMucDichSuDung dmmucdichsudung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmmucdichsudung).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Chỉnh sửa Mục đích sử dụng thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Chỉnh sửa Mục đích sử dụng không thành công";
                return RedirectToAction("Index");
            }
            return View(dmmucdichsudung);
        }

        //
        // GET: /dmMucDichSuDung/Delete/5

        public ActionResult Delete(int id = 0)
        {
            dmMucDichSuDung dmmucdichsudung = db.dmMucDichSuDung.Find(id);
            if (dmmucdichsudung == null)
            {
                return HttpNotFound();
            }
            return View(dmmucdichsudung);
        }

        //
        // POST: /dmMucDichSuDung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmMucDichSuDung dmmucdichsudung = db.dmMucDichSuDung.Find(id);
            db.dmMucDichSuDung.Remove(dmmucdichsudung);
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