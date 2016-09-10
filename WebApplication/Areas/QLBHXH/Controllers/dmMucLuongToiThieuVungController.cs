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
    public class dmMucLuongToiThieuVungController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmMucLuongToiThieuVung/

        public ActionResult Index()
        {
            //var model = (from MucLuongTTV in db.dmMucLuongToiThieuVung
            //             orderby MucLuongTTV.STT
            //             select MucLuongTTV).ToList();
            //for (int i = 0, c = 1; i < model.Count; i++, c++)
            //    if (model[i].STT != c)
            //    {
            //        model[i].STT = c;
            //        db.Entry(model[i]).State = EntityState.Modified;
            //    }
            //db.SaveChanges();
            return View(db.dmMucLuongToiThieuVung.ToList());
        }

        public ActionResult Index2()
        {
            //var model = (from MucLuongTTV in db.dmMucLuongToiThieuVung
            //             orderby MucLuongTTV.STT
            //             select MucLuongTTV).ToList();
            //for (int i = 0, c = 1; i < model.Count; i++, c++)
            //    if (model[i].STT != c)
            //    {
            //        model[i].STT = c;
            //        db.Entry(model[i]).State = EntityState.Modified;
            //    }
            //db.SaveChanges();
            return View(db.dmMucLuongToiThieuVung.ToList());
        }
        //
        // GET: /dmMucLuongToiThieuVung/Details/5

        public ActionResult Details(int id = 0)
        {
            dmMucLuongToiThieuVung dmmucluongtoithieuvung = db.dmMucLuongToiThieuVung.Find(id);
            if (dmmucluongtoithieuvung == null)
            {
                return HttpNotFound();
            }
            return View(dmmucluongtoithieuvung);
        }

        //
        // GET: /dmMucLuongToiThieuVung/Create

        public ViewResult Create()
        {
            return View();
        }

        //
        // POST: /dmMucLuongToiThieuVung/Create

        [HttpPost]
        public ActionResult Create(dmMucLuongToiThieuVung dmmucluongtoithieuvung)
        {
            if (ModelState.IsValid)
            {
                db.dmMucLuongToiThieuVung.Add(dmmucluongtoithieuvung);
                db.SaveChanges();
                TempData["Message"] = "Thêm mới thành công";
                return RedirectToAction("Index2", "dmMucLuongToiThieuVung");
            }

            return View(dmmucluongtoithieuvung);
        }

        //
        // GET: /dmMucLuongToiThieuVung/Edit/5

        public ViewResult Edit(int id = 0)
        {
            dmMucLuongToiThieuVung dmmucluongtoithieuvung = db.dmMucLuongToiThieuVung.Find(id);
            //if (dmmucluongtoithieuvung == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmmucluongtoithieuvung);
        }

        //
        // POST: /dmMucLuongToiThieuVung/Edit/5

        [HttpPost]
        public ActionResult Edit(dmMucLuongToiThieuVung dmmucluongtoithieuvung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmmucluongtoithieuvung).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Sửa thành công";
                return RedirectToAction("Index2", "dmMucLuongToiThieuVung");
            }
            return View(dmmucluongtoithieuvung);
        }

        //
        // GET: /dmMucLuongToiThieuVung/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            dmMucLuongToiThieuVung dmmucluongtoithieuvung = db.dmMucLuongToiThieuVung.Find(id);
            //if (dmmucluongtoithieuvung == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(dmmucluongtoithieuvung);
        }

        //
        // POST: /dmMucLuongToiThieuVung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmMucLuongToiThieuVung dmmucluongtoithieuvung = db.dmMucLuongToiThieuVung.Find(id);
            db.dmMucLuongToiThieuVung.Remove(dmmucluongtoithieuvung);
            db.SaveChanges();
            TempData["Message"] = "Thêm mới thành công";
            return RedirectToAction("Index2", "dmMucLuongToiThieuVung");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}