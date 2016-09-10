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
    public class dmGiayToController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmGiayTo/

        public ActionResult Index()
        {
            var model = (from GT in db.dmGiayTo
                         orderby GT.stt
                         select GT).ToList();
            for (int i = 0, c = 1; i < model.Count; i++, c++)
                if (model[i].stt != c)
                {
                    model[i].stt = c;
                    db.Entry(model[i]).State = EntityState.Modified;
                }
            db.SaveChanges();

            return View(db.dmGiayTo.ToList());
            //var dmgiaytoes = db.dmGiayTo.Include(d => d.MucDichSuDung);
            //return View(dmgiaytoes.ToList());
        }

        //
        // GET: /dmGiayTo/Details/5

        public ActionResult Details(int id = 0)
        {
            dmGiayTo dmgiayto = db.dmGiayTo.Find(id);
            if (dmgiayto == null)
            {
                return HttpNotFound();
            }
            return View(dmgiayto);
        }

        //
        // GET: /dmGiayTo/Create

        public ActionResult Create()
        {
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich");
            return View();
        }

        //
        // POST: /dmGiayTo/Create

        [HttpPost]
        public ActionResult Create(dmGiayTo dmgiayto)
        {
            if (ModelState.IsValid)
            {
                db.dmGiayTo.Add(dmgiayto);
                db.SaveChanges();
                TempData["Message"] = "Thêm Giấy tờ thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Thêm Giấy tờ không thành công";
                return RedirectToAction("Index");
            }
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich", dmgiayto.idMucDichSuDung);
            return View(dmgiayto);
        }

        //
        // GET: /dmGiayTo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            dmGiayTo dmgiayto = db.dmGiayTo.Find(id);
            if (dmgiayto == null)
            {
                return HttpNotFound();
            }
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich", dmgiayto.idMucDichSuDung);
            return View(dmgiayto);
        }

        //
        // POST: /dmGiayTo/Edit/5

        [HttpPost]
        public ActionResult Edit(dmGiayTo dmgiayto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmgiayto).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Chỉnh sửa Giấy tờ thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Chỉnh sửa Giấy tờ không thành công";
                return RedirectToAction("Index");
            }
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich", dmgiayto.idMucDichSuDung);
            return View(dmgiayto);
        }

        //
        // GET: /dmGiayTo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            dmGiayTo dmgiayto = db.dmGiayTo.Find(id);
            if (dmgiayto == null)
            {
                return HttpNotFound();
            }
            return View(dmgiayto);
        }

        //
        // POST: /dmGiayTo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmGiayTo dmgiayto = db.dmGiayTo.Find(id);
            db.dmGiayTo.Remove(dmgiayto);
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