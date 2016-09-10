using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

using HRM.QLBHXH.Models;

namespace HRM.QLBHXH.Controllers
{
    public class dmNoiKCBController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /dmNoiKCB/

        public ActionResult Index()
        {
            return View(    db.dmNoiKCB.ToList());
        }


        public ActionResult Index2()
        {
            return View(db.dmNoiKCB.ToList());
        }

        //
        // GET: /dmNoiKCB/Details/5

        public ActionResult Details(int id = 0)
        {
            dmNoiKCB dmnoikcb = db.dmNoiKCB.Find(id);
            if (dmnoikcb == null)
            {
                return HttpNotFound();
            }
            return View(dmnoikcb);
        }

        //
        // GET: /dmNoiKCB/Create

        public ViewResult Create()
        {
        
            return View();
        }

        //
        // POST: /dmNoiKCB/Create

        [HttpPost]
        public ActionResult Create(dmNoiKCB dmNoiKCBs)
        {
            if (ModelState.IsValid)
            {
                db.dmNoiKCB.Add(dmNoiKCBs);
                db.SaveChanges();
                TempData["Message"] = "Thêm mới thành công";
                return RedirectToAction("Index", "dmNoiKCB");
            }

            return View(dmNoiKCBs);
        }

        //
        // GET: /dmNoiKCB/Edit/5

        public ViewResult Edit(int id = 0)
        {
            dmNoiKCB dmnoikcb = db.dmNoiKCB.Find(id);
            //if (dmnoikcb == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmnoikcb);
        }

        //
        // POST: /dmNoiKCB/Edit/5

        [HttpPost]
        public ActionResult Edit(dmNoiKCB dmnoikcb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmnoikcb).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Sửa thành công";
                return RedirectToAction("Index", "dmNoiKCB");
            }
            return View(dmnoikcb);
        }

        //
        // GET: /dmNoiKCB/Delete/5

        public ViewResult Delete(int id = 0)
        {
            dmNoiKCB dmnoikcb = db.dmNoiKCB.Find(id);
            //if (dmnoikcb == null)
            //{
            //    return HttpNotFound();
            //}
            return View(dmnoikcb);
        }

        //
        // POST: /dmNoiKCB/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dmNoiKCB dmnoikcb = db.dmNoiKCB.Find(id);
            db.dmNoiKCB.Remove(dmnoikcb);
            db.SaveChanges();
            TempData["Message"] = "Xóa thành công";
            return RedirectToAction("Index", "dmNoiKCB");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}