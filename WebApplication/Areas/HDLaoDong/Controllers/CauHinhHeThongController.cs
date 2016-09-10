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
    public class CauHinhHeThongController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /CauHinhHeThong/Create

        public ActionResult Create()
        {
            var cauhinh = db.hdCauHinh.FirstOrDefault();
            ViewBag.id = cauhinh.id;
            return View(cauhinh);
        }

        //
        // POST: /CauHinhHeThong/Create

        [HttpPost]
        public ActionResult Create(hdCauHinh hdcauhinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hdcauhinh).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message_CauHinh"] = "Cập nhật thành công!";
                return RedirectToAction("Create","CauHinhHeThong");
            }
            TempData["Message_CauHinh"] = "Cập nhật thất bại!";
            return View(hdcauhinh);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}