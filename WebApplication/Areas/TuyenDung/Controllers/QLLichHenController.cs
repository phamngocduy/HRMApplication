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
    public class QLLichHenController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /QLLichHen/

        public ActionResult Index()
        {
            //var tdxemvaxeplichhens = db.tdXemVaXepLichHen.Include(t => t.tdTTUngCuVien);
            return View();
        }
        public PartialViewResult Index1(int ungvienid)
        {
            ViewBag.ungvienid = ungvienid;
            //var tdxemvaxeplichhens = db.tdXemVaXepLichHen.Include(t => t.tdTTUngCuVien);
            return PartialView();
        }

        ////
        //// GET: /QLLichHen/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    tdXemVaXepLichHen tdxemvaxeplichhen = db.tdXemVaXepLichHen.Find(id);
        //    if (tdxemvaxeplichhen == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdxemvaxeplichhen);
        //}

        ////
        //// GET: /QLLichHen/Create

        //public ActionResult Create()
        //{
        //    ViewBag.UngCuVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen");
        //    return View();
        //}

        ////
        //// POST: /QLLichHen/Create

        //[HttpPost]
        //public ActionResult Create(tdXemVaXepLichHen tdxemvaxeplichhen)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tdXemVaXepLichHen.Add(tdxemvaxeplichhen);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.UngCuVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen", tdxemvaxeplichhen.UngCuVien_id);
        //    return View(tdxemvaxeplichhen);
        //}

        //
        // GET: /QLLichHen/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tdXemVaXepLichHen tdxemvaxeplichhen = db.tdXemVaXepLichHen.Find(id);
            if (tdxemvaxeplichhen == null)
            {
                return HttpNotFound();
            }
            return View(tdxemvaxeplichhen);
        }
        public ActionResult Edit1(int id = 0)
        {
            tdXemVaXepLichHen tdxemvaxeplichhen = db.tdXemVaXepLichHen.Find(id);
            if (tdxemvaxeplichhen == null)
            {
                return HttpNotFound();
            }
            return View(tdxemvaxeplichhen);
        }
        //
        // POST: /QLLichHen/Edit/5
         [HttpPost]
        public ActionResult Edit1(FormCollection form)
        {
            if (form["id"] != "")
            {
                var id = int.Parse(form["id"]);
                var ungvien_id = form["ungvienid"];
                var ngayphongvan = form["item.NgayPhongVan"];
                var gio = form["item.Gio"];
                var diadiemphongvan = form["item.DiaDiemPhongVan"];
                var donviphongvan = new int?();
                try
                {
                    donviphongvan = int.Parse(form["item.DonViPhongVan_id"]);
                }
                catch
                {
                    donviphongvan = null;
                }
                var dabaochoungvien = false;
                if (form["item.DaBaoChoUngCuVien"] == "true,false")
                {
                    dabaochoungvien = true;
                }
                var ghichu = form["item.GhiChu"];
                if (ModelState.IsValid)
                {
                    var old = db.tdXemVaXepLichHen.Find(id);
                    try
                    {
                        var newdata = new tdXemVaXepLichHen { id = id, UngCuVien_id = old.UngCuVien_id, NgayPhongVan = DateTime.Parse(ngayphongvan), Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                        db.Entry(old).CurrentValues.SetValues(newdata);
                    }
                    catch
                    {
                        var newdata = new tdXemVaXepLichHen { id = id, UngCuVien_id = old.UngCuVien_id, NgayPhongVan = null, Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                        db.Entry(old).CurrentValues.SetValues(newdata);
                    }

                    db.SaveChanges();
                    TempData["Message"] = "Bạn đã cập nhật thành công.";
                    return RedirectToAction("Index");
                }
            }
            else if (form["id"] == "")
            {
                if (form["ungvienid"] != "")
                {
                    var ngayphongvan = form["NgayPhongVan"];
                    var gio = form["Gio"];
                    var diadiemphongvan = form["DDPhongVan"];
                    var donviphongvan = new int?();
                    try
                    {
                        donviphongvan = int.Parse(form["DonViPhongVan_id"]);
                    }
                    catch
                    {
                        donviphongvan = null;
                    }
                    var ungvien_id = int.Parse(form["ungvienid"]);
                    var dabaochoungvien = false;
                    if (form["DaBaoChoUngCuVien"] == "true,false")
                    {
                        dabaochoungvien = true;
                    }
                    var ghichu = form["GhiChu"];
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = ungvien_id, NgayPhongVan = DateTime.Parse(ngayphongvan), Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                            db.tdXemVaXepLichHen.Add(tdqllichhen);
                            db.SaveChanges();
                            var temptlist = db.tdXemVaXepLichHen.ToList().Last();
                            var tdquatrinhtd = new tdQuaTrinhTuyenDung { UngVien_id = ungvien_id, QuanLyLH_id = temptlist.id };
                            db.tdQuaTrinhTuyenDung.Add(tdquatrinhtd);
                        }
                        catch
                        {
                            var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = ungvien_id, NgayPhongVan = null, Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                            db.tdXemVaXepLichHen.Add(tdqllichhen);
                            db.SaveChanges();
                            var temptlist = db.tdXemVaXepLichHen.ToList().Last();
                            var tdquatrinhtd = new tdQuaTrinhTuyenDung { UngVien_id = ungvien_id, QuanLyLH_id = temptlist.id };
                            db.tdQuaTrinhTuyenDung.Add(tdquatrinhtd);
                        }
                        db.SaveChanges();
                        TempData["Message"] = "Bạn đã thêm mới thành công.";

                    }
                }
                else
                {
                    TempData["Message"] = "Thêm mới thất bại. Bạn chưa chọn tên ứng viên.";
                }
                return RedirectToAction("Index");
            }
            return null;
            //ViewBag.UngCuVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen", tdxemvaxeplichhen.UngCuVien_id);
            //return View(tdxemvaxeplichhen);
        }
        [HttpPost]
        //public ActionResult Edit(tdXemVaXepLichHen tdxemvaxeplichhen)
        public ActionResult Edit(FormCollection form)
        {
            if (form[0] != "")
            {
                var id = int.Parse(form[0]);
                var ngayphongvan = form[1];
                var gio = form[2];
                var diadiemphongvan = form[3];
                var donviphongvan = new int?();
                try
                {
                    donviphongvan = int.Parse(form[4]);
                }
                catch
                {
                    donviphongvan = null;
                }
                var dabaochoungvien = false;
                if (form[5] == "true,false")
                {
                    dabaochoungvien = true;
                }
                var ghichu = form[6];
                if (ModelState.IsValid)
                {
                    var old = db.tdXemVaXepLichHen.Find(id);
                    try
                    {
                        var newdata = new tdXemVaXepLichHen { id = id, UngCuVien_id = old.UngCuVien_id, NgayPhongVan = DateTime.Parse(ngayphongvan), Gio = gio, DiaDiemPhongVan = diadiemphongvan,DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                        db.Entry(old).CurrentValues.SetValues(newdata);
                    }
                    catch
                    {
                        var newdata = new tdXemVaXepLichHen { id = id, UngCuVien_id = old.UngCuVien_id, NgayPhongVan = null, Gio = gio, DiaDiemPhongVan = diadiemphongvan,DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                        db.Entry(old).CurrentValues.SetValues(newdata);
                    }

                    db.SaveChanges();
                    TempData["Message"] = "Bạn đã cập nhật thành công."; 
                    return RedirectToAction("Index");
                }
            }
            else if(form[0] == "")
            {
                if (form[5] != "")
                {
                    var ngayphongvan = form[1];
                    var gio = form[2];
                    var diadiemphongvan = form[3];
                    var donviphongvan = new int?();
                    try
                    {
                        donviphongvan = int.Parse(form[4]);
                    }
                    catch
                    {
                        donviphongvan = null;
                    }
                    var ungvien_id = int.Parse(form[5]);
                    var dabaochoungvien = false;
                    if (form[6] == "true,false")
                    {
                        dabaochoungvien = true;
                    }
                    var ghichu = form[7];
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = ungvien_id, NgayPhongVan = DateTime.Parse(ngayphongvan), Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                            db.tdXemVaXepLichHen.Add(tdqllichhen);
                            db.SaveChanges();
                            var temptlist = db.tdXemVaXepLichHen.ToList().Last();
                            var tdquatrinhtd = new tdQuaTrinhTuyenDung { UngVien_id = ungvien_id, QuanLyLH_id = temptlist.id};
                            db.tdQuaTrinhTuyenDung.Add(tdquatrinhtd);
                        }
                        catch
                        {
                            var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = ungvien_id, NgayPhongVan = null, Gio = gio, DiaDiemPhongVan = diadiemphongvan, DonViPhongVan_id = donviphongvan, DaBaoChoUngCuVien = dabaochoungvien, GhiChu = ghichu };
                            db.tdXemVaXepLichHen.Add(tdqllichhen);
                            db.SaveChanges();
                            var temptlist = db.tdXemVaXepLichHen.ToList().Last();
                            var tdquatrinhtd = new tdQuaTrinhTuyenDung { UngVien_id = ungvien_id, QuanLyLH_id = temptlist.id};
                            db.tdQuaTrinhTuyenDung.Add(tdquatrinhtd);
                        }
                        db.SaveChanges();
                        TempData["Message"] = "Bạn đã thêm mới thành công.";

                    }
                }
                else
                {
                    TempData["Message"] = "Thêm mới thất bại. Bạn chưa chọn tên ứng viên.";
                }
                return RedirectToAction("Index");
            }
            return null;
            //ViewBag.UngCuVien_id = new SelectList(db.tdTTUngCuVien, "id", "HoVaTen", tdxemvaxeplichhen.UngCuVien_id);
            //return View(tdxemvaxeplichhen);
        }
        ////
        //// GET: /QLLichHen/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdXemVaXepLichHen tdxemvaxeplichhen = db.tdXemVaXepLichHen.Find(id);
        //    if (tdxemvaxeplichhen == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdxemvaxeplichhen);
        //}

        ////
        //// POST: /QLLichHen/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdXemVaXepLichHen tdxemvaxeplichhen = db.tdXemVaXepLichHen.Find(id);
        //    db.tdXemVaXepLichHen.Remove(tdxemvaxeplichhen);
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