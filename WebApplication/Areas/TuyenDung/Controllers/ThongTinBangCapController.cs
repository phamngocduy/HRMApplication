using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;


namespace HRM.TuyenDung.Controllers
{
    public class ThongTinBangCapController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /ThongTinBangCap/

        public ActionResult Index()
        {
            var tdbangcaps = db.tdBangCap;
            return View(tdbangcaps.ToList());
        }

        //
        // GET: /ThongTinBangCap/Details/5

        public ActionResult Details(int id = 0)
        {
            tdBangCap tdbangcap = db.tdBangCap.Find(id);
            if (tdbangcap == null)
            {
                return HttpNotFound();
            }
            return View(tdbangcap);
        }

        //
        // GET: /ThongTinBangCap/Create

        public ActionResult Create(int UV_id = 0)
        {
            ViewBag.UngVien_id = UV_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UV_id);
            return View();
        }

        //
        // POST: /ThongTinBangCap/Create

        [HttpPost]
        public ActionResult Create(tdBangCap tdbangcap)
        {
            if (tdbangcap.id == 0)
            {
                db.tdBangCap.Add(tdbangcap);
                db.SaveChanges();
                return RedirectToAction("Create", "TuyenDung", new { tab = "ThongTinBangCap", UV_id = tdbangcap.UngVien_id });
            }
            else
            {
                try
                {
                    tdbangcap.TrinhDo_id = int.Parse(Request.Form[2]);
                }
                catch
                {
                    tdbangcap.TrinhDo_id = null;
                }
                try
                {
                    tdbangcap.ChuyenNganh_id = int.Parse(Request.Form[3]);
                }
                catch
                {
                    tdbangcap.ChuyenNganh_id = null;
                }
                tdbangcap.NoiDaoTao = Request.Form[4];
                try
                {
                    tdbangcap.NamTotNghiep = int.Parse(Request.Form[5]);
                }
                catch
                {
                    tdbangcap.NamTotNghiep = null;
                }
                try
                {
                    tdbangcap.XepLoai_id = int.Parse(Request.Form[6]);
                }
                catch
                {
                    tdbangcap.XepLoai_id = null;
                }
                if (Request.Form[7] == "true,false")
                {
                    tdbangcap.SetDefault = true;
                }
                else
                {
                    tdbangcap.SetDefault = false;
                }
                db.Entry(tdbangcap).State = EntityState.Modified;
                db.SaveChanges();
                var tempt = db.tdBangCap.Where(bc => bc.id != tdbangcap.id);
                foreach (var item in tempt)
                {
                    item.SetDefault = false;
                    db.Entry(item).State = EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Create", "TuyenDung", new { tab = "ThongTinBangCap", UV_id = tdbangcap.UngVien_id });
            }
        }

        //
        // GET: /ThongTinBangCap/Edit/5

        public ActionResult Edit(int UV_id = 0)
        {
            ViewBag.UngVien_id = UV_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UV_id);
            //tdBangCap tdbangcap = db.tdBangCap.Find(id);
            //if (tdbangcap == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

        //
        // POST: /ThongTinBangCap/Edit/5

        [HttpPost]
        public ActionResult Edit(tdBangCap tdbangcap)
        {
           
                //db.Entry(tdbangcap).State = EntityState.Modified;
            if (tdbangcap.id == 0)
            {
                db.tdBangCap.Add(tdbangcap);
                db.SaveChanges();
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinBangCap", nat = "Edit", id = tdbangcap.UngVien_id });
            }
            else
            {
                try
                {
                    tdbangcap.TrinhDo_id = int.Parse(Request.Form[2]);
                }
                catch
                {
                    tdbangcap.TrinhDo_id = null;
                }
                try
                {
                    tdbangcap.ChuyenNganh_id = int.Parse(Request.Form[3]);
                }
                catch
                {
                    tdbangcap.ChuyenNganh_id = null;
                }
                tdbangcap.NoiDaoTao = Request.Form[4];
                try
                {
                    tdbangcap.NamTotNghiep = int.Parse(Request.Form[5]);
                }
                catch
                {
                    tdbangcap.NamTotNghiep = null;
                }
                try
                {
                    tdbangcap.XepLoai_id = int.Parse(Request.Form[6]);
                }
                catch
                {
                    tdbangcap.XepLoai_id = null;
                }
                if (Request.Form[7] == "true,false")
                {
                    tdbangcap.SetDefault = true;
                }
                else
                {
                    tdbangcap.SetDefault = false;
                }
                db.Entry(tdbangcap).State = EntityState.Modified;
                db.SaveChanges();
                var tempt = db.tdBangCap.Where(bc => bc.id != tdbangcap.id);
                foreach (var item in tempt)
                {
                    item.SetDefault = false;
                    db.Entry(item).State = EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinBangCap", nat = "Edit", id = tdbangcap.UngVien_id });
            }
        }

        //
        // GET: /ThongTinBangCap/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tdBangCap tdbangcap = db.tdBangCap.Find(id);
            if (tdbangcap == null)
            {
                return HttpNotFound();
            }
            return View(tdbangcap);
        }

        //
        // POST: /ThongTinBangCap/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tdBangCap tdbangcap = db.tdBangCap.Find(id);
            db.tdBangCap.Remove(tdbangcap);
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