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
    public class dmMucLuongToiThieuChungController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmMucLuongToiThieuChung/

        public ActionResult Index()
        {

           
            return View(db.dmMucLuongToiThieuChung.ToList());
        }

        public ActionResult Index2()
        {
            return View(db.dmMucLuongToiThieuChung.ToList());
        }

        //
        // GET: /dmMucLuongToiThieuChung/Details/5

        public ActionResult Details(int id = 0)
        {
            dmMucLuongToiThieuChung dmmucluongtoithieuchung = db.dmMucLuongToiThieuChung.Find(id);
            if (dmmucluongtoithieuchung == null)
            {
                return HttpNotFound();
            }
            return View(dmmucluongtoithieuchung);
        }

        //
        // GET: /dmMucLuongToiThieuChung/Create

        public ViewResult Create()
        {
            return View();
        }

        //
        // POST: /dmMucLuongToiThieuChung/Create

        [HttpPost]
        public ActionResult Create(dmMucLuongToiThieuChung dmmucluongtoithieuchung)
        {
            if (ModelState.IsValid)
            {
                db.dmMucLuongToiThieuChung.Add(dmmucluongtoithieuchung);
                db.SaveChanges();
                TempData["Message"] = "Thêm mới thành công";
                return RedirectToAction("Index", "dmMucLuongToiThieuChung");
               
            }

            return View(dmmucluongtoithieuchung);
        }

        //
        // GET: /dmMucLuongToiThieuChung/Edit/5

        public ViewResult Edit(int id = 0)
        {
            dmMucLuongToiThieuChung dmmucluongtoithieuchung = db.dmMucLuongToiThieuChung.Find(id);
            //if (dmmucluongtoithieuchung == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmmucluongtoithieuchung);
        }

  
        //
        // POST: /dmMucLuongToiThieuChung/Edit/5

        [HttpPost]
        public ActionResult Edit(dmMucLuongToiThieuChung dmmucluongtoithieuchung)
        {
          

            if (ModelState.IsValid)
            {
                db.Entry(dmmucluongtoithieuchung).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Sửa thành công";
                return RedirectToAction("Index", "dmmucluongtoithieuchung");
            }
            return View(dmmucluongtoithieuchung);
        }

        //
        // GET: /dmMucLuongToiThieuChung/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            dmMucLuongToiThieuChung dmmucluongtoithieuchung = db.dmMucLuongToiThieuChung.Find(id);
            //if (dmmucluongtoithieuchung == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(dmmucluongtoithieuchung);
        }

        //
        // POST: /dmMucLuongToiThieuChung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmMucLuongToiThieuChung dmmucluongtoithieuchung = db.dmMucLuongToiThieuChung.Find(id);
            db.dmMucLuongToiThieuChung.Remove(dmmucluongtoithieuchung);
            db.SaveChanges();
            TempData["Message"] = "Xóa thành công";
            return RedirectToAction("Index", "dmMucLuongToiThieuChung");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}