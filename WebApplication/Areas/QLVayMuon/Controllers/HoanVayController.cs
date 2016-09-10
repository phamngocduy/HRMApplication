using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

using HRM.QLVayMuon.Models;
namespace HRM.QLVayMuon.Controllers
{
    public class HoanVayController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();
        // GET: /HoanVay/
        public ActionResult Index(int NV_id = 0)
        {
            //truyen id nhanvienvaymuon cho index cua hoanvay 
            ViewBag.NV_id = NV_id;
            //lay tat ca hoanvay co ID nhanvienvaymuon =NV_id
            var hoanvay = from h in db.HoanVay
                          where h.KhoanVay.idNhanVienVayMuon == NV_id
                          orderby h.id descending
                          select h;
            return View(hoanvay.ToList());
        }
        //
        // GET: /HoanVay/Details/5
        //public ActionResult Details(int id = 0)
        //{
        //    //tim hoanvay cos id= id
        //    HoanVay hoanvay = db.HoanVay.Find(id);
        //    if (hoanvay == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(hoanvay);
        //}
        //
        // GET: /HoanVay/Create

        public ActionResult Create(int id = 0)
        {
            //var affectedRows = db.Database.ExecuteSqlCommand("TONGHOPVAY @DAY1, @DAY2",
            //new SqlParameter("@DAY1", "1/1/2012"),
            //new SqlParameter("@DAY2", "1/1/2015"));
            ViewBag.NV_id = id;
            //lay ra tat ca khoanvay cos id=id 
            var khoanvay = from k in db.KhoanVay
                           where k.idNhanVienVayMuon == id && (k.DatraXong == false)
                           select k;
            try
            {   //tao ra combobox tat ca khoanvay cos id=id
                int idKV = khoanvay.FirstOrDefault().id;
                ViewBag.idKhoanVay = new SelectList((from kv in khoanvay select new { id = kv.id, SoChungTu = kv.SoChungTu + (kv.DinhMuc == true ? " - Định mức" : " - Ngoài định mức") }), "id", "SoChungTu", idKV);
            }
            catch
            {
                ViewBag.idKhoanVay = new SelectList((from kv in khoanvay select new { id = kv.id, SoChungTu = kv.SoChungTu + (kv.DinhMuc == true ? " - Định mức" : " - Ngoài định mức") }), "id", "SoChungTu", null);
            }
            return View();
        }

        //
        // POST: /HoanVay/Create
        [HttpPost]
        public ActionResult Create(HoanVay hoanvay)
        {
            hoanvay.KhoanVay = db.KhoanVay.Find(hoanvay.idKhoanVay);
            try
            {
                if (ModelState.IsValid)
                {   //them hoanvay vao database
                    db.HoanVay.Add(hoanvay);
                    db.SaveChanges();
                    //thong bao thanh cong ra man hinh
                    TempData["Message"] = "Thêm mới hoàn vay thành công";
                }
            }
            catch
            {    //neu thong tin bi trung hay loi thi hien ra thong bao loi
                TempData["Message"] = "Thêm mới hoàn vay không thành công";
            }

            if (hoanvay.KhoanVay != null)
            {   //tro lai man hinh index cua hoanvay co id=NV_id
                return RedirectToAction("Index", new { NV_id = hoanvay.KhoanVay.idNhanVienVayMuon });
            }
            else
            {
                return View(hoanvay);
            }

        }


        //
        // GET: /HoanVay/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.HV_id = id;
            //tim hoanvay co id=id
            HoanVay hoanvay = db.HoanVay.Find(id);
            if (hoanvay == null)
            {
                return HttpNotFound();
            }
            //lay tat ca khoanvay cos id= 
            var khoanvay = from k in db.KhoanVay
                           where k.id == hoanvay.idKhoanVay
                           select k;

            //ViewBag.idKhoanVay = new SelectList(db.KhoanVay, "id", "SoChungTu", hoanvay.idKhoanVay );
            //ViewBag.idKhoanVay = new SelectList(khoanvay, "id", "SoChungTu", hoanvay.idKhoanVay);
            return View(hoanvay);
        }

        //
        // POST: /HoanVay/Edit/5

        [HttpPost]
        public ActionResult Edit(HoanVay hoanvay)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(hoanvay).State = EntityState.Modified;
                    //luu lai hoanvay 
                    db.SaveChanges();
                    //tim khoanvay co id=hoanvay.idKhoanVay
                    hoanvay.KhoanVay = db.KhoanVay.Find(hoanvay.idKhoanVay);
                    TempData["Message"] = "Chỉnh sửa hoàn vay thành công";
                    //tro lai index cua hoanvay co nv_id=hoanvay.KhoanVay.idNhanVienVayMuon
                    return RedirectToAction("Index", new { NV_id = hoanvay.KhoanVay.idNhanVienVayMuon });
                }
            }
            catch
            {
                TempData["Message"] = "Chỉnh sửa hoàn vay không thành công";
            }
            return View(hoanvay);
        }

        //
        // GET: /HoanVay/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.HV_id = id;
            //tim hoanvay co id=id
            HoanVay hoanvay = db.HoanVay.Find(id);
            //neu hoanvay khong ton tai bao loi
            if (hoanvay == null)
            {
                return HttpNotFound();
            }
            //tra hoanvay ra delete view
            return View(hoanvay);
        }

        //
        // POST: /HoanVay/Delete/5

        [HttpPost, ActionName("Delete")]
        //review lai truoc khi xoa
        public ActionResult DeleteConfirmed(int id)
        {
            HoanVay hoanvay = db.HoanVay.Find(id);
            //lay ra id khoanvay cua hoanvay vua xoa
            int nvid = hoanvay.KhoanVay.idNhanVienVayMuon;
            try
            {
                //xoa hoanvay ra khoi database
                db.HoanVay.Remove(hoanvay);
                db.SaveChanges();
                //thong bao thanh cong
                TempData["Message"] = "Xóa hoàn vay thành công";

            }
            catch
            {
                TempData["Message"] = "Xóa hoàn vay không thành công";
            }
            //chuyen huong ve trang index co NV_id = nvid 
            return RedirectToAction("Index", new { NV_id = nvid });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}