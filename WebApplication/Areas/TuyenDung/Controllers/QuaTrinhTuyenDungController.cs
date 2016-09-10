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
    public class QuaTrinhTuyenDungController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /QuaTrinhTuyenDung/

        public ActionResult Index(int UV_id)
        {
            ViewBag.UngVien_id = UV_id;
            int id = UV_id;
            var tdttungcuvien = db.tdTTUngCuVien.Where(uv => uv.id == id).First();
            ViewBag.Name = tdttungcuvien.HoVaTen;
            return View();
        }

        ////
        //// GET: /QuaTrinhTuyenDung/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    tdQuaTrinhTuyenDung tdquatrinhtuyendung = db.tdQuaTrinhTuyenDung.Find(id);
        //    if (tdquatrinhtuyendung == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdquatrinhtuyendung);
        //}

        ////
        //// GET: /QuaTrinhTuyenDung/Create

        //public ActionResult Create()
        //{
        //    ViewBag.UngVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen");
        //    return View();
        //}

        ////
        //// POST: /QuaTrinhTuyenDung/Create

        //[HttpPost]
        //public ActionResult Create(tdQuaTrinhTuyenDung tdquatrinhtuyendung)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tdQuaTrinhTuyenDung.Add(tdquatrinhtuyendung);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.UngVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen", tdquatrinhtuyendung.UngVien_id);
        //    return View(tdquatrinhtuyendung);
        //}

        //
        // GET: /QuaTrinhTuyenDung/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tdQuaTrinhTuyenDung tdquatrinhtuyendung = db.tdQuaTrinhTuyenDung.Find(id);
            if (tdquatrinhtuyendung == null)
            {
                return HttpNotFound();
            }
            return View(tdquatrinhtuyendung);
        }

        //
        // POST: /QuaTrinhTuyenDung/Edit/5

        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            if (ModelState.IsValid)
            {
                int? UV_id = null;
                if (form[0] != "")
                {
                    var id = int.Parse(form[0]);
                    var hinhthucphongvan = form[1];
                    var nhanxet = form[2];
                    var ghichu = form[3];
                    var old = db.tdQuaTrinhTuyenDung.Find(id);
                    var newdata = new tdQuaTrinhTuyenDung { id = id, UngVien_id = old.UngVien_id,QuanLyLH_id = old.QuanLyLH_id, HinhThucPhongVan = hinhthucphongvan, NhanXet = nhanxet, GhiChu = ghichu };
                    db.Entry(old).CurrentValues.SetValues(newdata);
                    TempData["UngVien_id"] = old.UngVien_id;
                    TempData["Message"] = "Bạn đã cập nhật thành công.";
                    UV_id = old.UngVien_id;
                }
                //else
                //{
                //    var ungvien_id = int.Parse(form[1]);
                //    var ngayphongvan = form[2];
                //    var donviphongvan = form[3];
                //    var hinhthucphongvan = form[4];
                //    var nhanxet = form[5];
                //    var ghichu = form[6];
                //    try
                //    {
                //        var newdata = new tdQuaTrinhTuyenDung {UngVien_id = ungvien_id, NgayPhongVanGiangThu = DateTime.Parse(ngayphongvan), DonViPhongVan = donviphongvan, HinhThucPhongVan = hinhthucphongvan, NhanXet = nhanxet, GhiChu = ghichu };
                //        db.tdQuaTrinhTuyenDung.Add(newdata);
                //    }
                //    catch
                //    {
                //        var newdata = new tdQuaTrinhTuyenDung { UngVien_id = ungvien_id, NgayPhongVanGiangThu = null, DonViPhongVan = donviphongvan, HinhThucPhongVan = hinhthucphongvan, NhanXet = nhanxet, GhiChu = ghichu };
                //        db.tdQuaTrinhTuyenDung.Add(newdata);
                //    }
                //    TempData["UngVien_id"] = ungvien_id;
                //}
                db.SaveChanges();

                return RedirectToAction("Index", new { UV_id = UV_id });
            }
            return View();
        }

        ////
        //// GET: /QuaTrinhTuyenDung/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdQuaTrinhTuyenDung tdquatrinhtuyendung = db.tdQuaTrinhTuyenDung.Find(id);
        //    if (tdquatrinhtuyendung == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdquatrinhtuyendung);
        //}

        ////
        //// POST: /QuaTrinhTuyenDung/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdQuaTrinhTuyenDung tdquatrinhtuyendung = db.tdQuaTrinhTuyenDung.Find(id);
        //    db.tdQuaTrinhTuyenDung.Remove(tdquatrinhtuyendung);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}