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
    public class QTBHXHController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /QTBHXH/

        //public ActionResult Index()
        //{
        //    var nvbhquatrinhbhxhs = db.nvbhQuaTrinhBHXH.Include(n => n.nvbhNhanVienBHXH);
        //    return View(nvbhquatrinhbhxhs.ToList());
        //}


        public ActionResult Index2(int id)
        {

       

           var tongnambhxh1 = (from nv1 in db.nvbhNhanVienBHXH where nv1.NV_id==id select nv1.SoNamThamGiaBHXH).First();
      var tongthangbhxh1 = (from nv2 in db.nvbhNhanVienBHXH where nv2.NV_id == id select nv2.SoThangThamGiaBHXH).First();
            var tongnambhtn1 = (from nv3 in db.nvbhNhanVienBHXH where nv3.NV_id == id select nv3.SoNamThamGiaBHTNT).First();
            var tongthangbhtn1 = (from nv4 in db.nvbhNhanVienBHXH where nv4.NV_id == id select nv4.SoThangThamGiaBHTN).First();

           ViewBag.tongnambhxh=tongnambhxh1;
           ViewBag.tongthangbhxh=tongthangbhxh1;
           ViewBag.tongnambhtn=tongnambhtn1;
           ViewBag.tongthangbhtn = tongthangbhtn1;

            var nvbhquatrinhbhxhs = from h in db.v_qtbhxh
                                    where h.NV_ID == id
                                    select h;
            string ten = (from nv in db.nvbhNhanVienBHXH where nv.NV_id == id select nv.HoVaTen).First();
            ViewBag.ten1 = ten;

            return View(nvbhquatrinhbhxhs.ToList());
        }
        //
        // GET: /QTBHXH/Details/5

        public ActionResult Details(int id = 0)
        {
            nvbhQuaTrinhBHXH nvbhquatrinhbhxh = db.nvbhQuaTrinhBHXH.Find(id);
            if (nvbhquatrinhbhxh == null)
            {
                return HttpNotFound();
            }
            return View(nvbhquatrinhbhxh);
        }

        //
        // GET: /QTBHXH/Create

        public ActionResult Create()
        {
            ViewBag.idNVBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen");
            return View();
        }

        //
        // POST: /QTBHXH/Create

        [HttpPost]
        public ActionResult Create(nvbhQuaTrinhBHXH nvbhquatrinhbhxh)
        {
            if (ModelState.IsValid)
            {
                db.nvbhQuaTrinhBHXH.Add(nvbhquatrinhbhxh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idNVBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhquatrinhbhxh.idNVBHXH);
            return View(nvbhquatrinhbhxh);
        }

        //
        // GET: /QTBHXH/Edit/5

        public ActionResult Edit(int id = 0)
        {
            nvbhQuaTrinhBHXH nvbhquatrinhbhxh = db.nvbhQuaTrinhBHXH.Find(id);
            if (nvbhquatrinhbhxh == null)
            {
                return HttpNotFound();
            }
            ViewBag.idNVBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhquatrinhbhxh.idNVBHXH);
            return View(nvbhquatrinhbhxh);
        }

        //
        // POST: /QTBHXH/Edit/5

        [HttpPost]
        public ActionResult Edit(nvbhQuaTrinhBHXH nvbhquatrinhbhxh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvbhquatrinhbhxh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idNVBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhquatrinhbhxh.idNVBHXH);
            return View(nvbhquatrinhbhxh);
        }

        //
        // GET: /QTBHXH/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            nvbhQuaTrinhBHXH nvbhquatrinhbhxh = db.nvbhQuaTrinhBHXH.Find(id);

            int idnv=nvbhquatrinhbhxh.NV_ID.Value;
            var  tennv = (from nv in db.nvbhNhanVienBHXH where nv.NV_id ==idnv select nv.HoVaTen).First();
            ViewBag.nvten = tennv;
            return PartialView(nvbhquatrinhbhxh);
        }

        //
        // POST: /QTBHXH/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            nvbhQuaTrinhBHXH nvbhquatrinhbhxh = db.nvbhQuaTrinhBHXH.Find(id);
            db.nvbhQuaTrinhBHXH.Remove(nvbhquatrinhbhxh);
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