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
    public class dmTyLeDongBHController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmTyLeDongBH/

        public ActionResult Index()
        {
            //var model = (from TyLeDongBH in db.dmTyLeDongBHXH
            //             orderby TyLeDongBH.STT
            //             select TyLeDongBH).ToList();
            //for (int i = 0, c = 1; i < model.Count; i++, c++)
            //    if (model[i].STT != c)
            //    {'
            //        model[i].STT = c;
            //        db.Entry(model[i]).State = EntityState.Modified;
            //    }
            //db.SaveChanges();

            return View(db.dmTyLeDongBHXH.ToList());
        }



        public ActionResult Index2()
        {
           
            return View(db.dmTyLeDongBHXH.ToList());
        }

        //
        // GET: /dmTyLeDongBH/Details/5

        public ActionResult Details(int id = 0)
        {
            dmTyLeDongBHXH dmtyledongbhxh = db.dmTyLeDongBHXH.Find(id);
            if (dmtyledongbhxh == null)
            {
                return HttpNotFound();
            }
            return View(dmtyledongbhxh);
        }

        
         //GET: /dmTyLeDongBH/Create

        public ViewResult Create()
        {
            return View();
        }

        //
        // POST: /dmTyLeDongBH/Create

        [HttpPost]
        public ActionResult Create(dmTyLeDongBHXH dmtyledongbhxh)
        {
            if (ModelState.IsValid)
            {
                db.dmTyLeDongBHXH.Add(dmtyledongbhxh);
                db.SaveChanges();
                TempData["Message"] = "Thêm mới thành công";
                return RedirectToAction("Index", "dmTyLeDongBH");
            }

            return View(dmtyledongbhxh);
        }

        //
        // GET: /dmTyLeDongBH/Edit/5

        public ViewResult Edit(int id = 0)
        {
            dmTyLeDongBHXH dmtyledongbhxh = db.dmTyLeDongBHXH.Find(id);
            //if (dmtyledongbhxh == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmtyledongbhxh);
        }

        //
        // POST: /dmTyLeDongBH/Edit/5

        [HttpPost]
        public ActionResult Edit(dmTyLeDongBHXH dmtyledongbhxh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmtyledongbhxh).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Sửa thành công";
                return RedirectToAction("Index", "dmTyLeDongBH");
            }
            return View(dmtyledongbhxh);
        }

        //
        // GET: /dmTyLeDongBH/Delete/5

        public ViewResult Delete(int id = 0)
        {
            dmTyLeDongBHXH dmtyledongbhxh = db.dmTyLeDongBHXH.Find(id);
            //if (dmtyledongbhxh == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmtyledongbhxh);
        }

        //
        // POST: /dmTyLeDongBH/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmTyLeDongBHXH dmtyledongbhxh = db.dmTyLeDongBHXH.Find(id);
            db.dmTyLeDongBHXH.Remove(dmtyledongbhxh);
            db.SaveChanges();
            TempData["Message"] = "Xóa thành công";
            return RedirectToAction("Index", "dmTyLeDongBH");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}