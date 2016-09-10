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
    public class DanhMucController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /DanhMuc/ThoiHanHD

        public ActionResult Index_dmThoiHanHD()
        {
            return View(db.dmThoiHanHD.ToList());
        }

        //
        // POST: /DanhMuc/Create/ThoiHanHD

        [HttpPost]
        public ActionResult Create_dmThoiHanHD(dmThoiHanHD dmthoihanhd)
        {
            if (Request.Form["valThoiHanHD"] != null && Request.Form["valThoiHanHD"] != "")
            {
                if (Request.Form["Type"] == "=")
                {
                    if (Request.Form["loaiHopDong"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = false;
                    if (dmthoihanhd.valThoiHanHD < 12)
                    {
                        dmthoihanhd.Duoi = true;
                    }
                }
                else if (Request.Form["Type"] == "<")
                {
                    if (Request.Form["loaiHopDong"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = "Dưới " + Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = "Dưới " + Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = true;
                }
                else if (Request.Form["Type"] == ">")
                {
                    if (Request.Form["loaiHopDong"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = "Trên " + Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = "Trên " + Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = false;
                }
                else
                {
                    if (Request.Form["loaiHopDong"] == "Hợp đồng cơ hữu")
                    {
                        dmthoihanhd.tenThoiHanHD = "KXĐTH";
                    }
                }
                if (ModelState.IsValid)
                {
                    db.dmThoiHanHD.Add(dmthoihanhd);
                    db.SaveChanges();
                    TempData["Message_DanhMuc"] = "Thêm mới thành công!";
                    return RedirectToAction("Index_dmThoiHanHD", "DanhMuc");
                }
            }
            TempData["Message_DanhMuc"] = "Thêm mới thất bại!";
            return RedirectToAction("Index_dmThoiHanHD", "DanhMuc");
        }

        //
        // POST: /DanhMuc/Edit/ThoiHanHD

        [HttpPost]
        public ActionResult Edit_dmThoiHanHD(dmThoiHanHD dmthoihanhd)
        {
            if (Request.Form["valThoiHanHD"] != null && Request.Form["valThoiHanHD"] != "")
            {
                if (Request.Form["Type_edit"] == "=")
                {
                    if (Request.Form["loaiHopDong_edit"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = false;
                    if (dmthoihanhd.valThoiHanHD < 12)
                    {
                        dmthoihanhd.Duoi = true;
                    }
                }
                else if (Request.Form["Type_edit"] == "<")
                {
                    if (Request.Form["loaiHopDong_edit"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = "Dưới " + Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = "Dưới " + Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = true;
                }
                else if (Request.Form["Type_edit"] == ">")
                {
                    if (Request.Form["loaiHopDong_edit"] == "Thử việc")
                    {
                        dmthoihanhd.tenThoiHanHD = "Trên " + Request.Form["valThoiHanHD"] + " ngày";
                    }
                    else
                    {
                        dmthoihanhd.tenThoiHanHD = "Trên " + Request.Form["valThoiHanHD"] + " tháng";
                    }
                    dmthoihanhd.Duoi = false;
                }
                else
                {
                    if (Request.Form["loaiHopDong_edit"] == "Hợp đồng cơ hữu")
                    {
                        dmthoihanhd.tenThoiHanHD = "KXĐTH";
                    }
                }
                dmthoihanhd.loaiHopDong = Request.Form["loaiHopDong_edit"];
                if (dmthoihanhd.id != null && dmthoihanhd.tenThoiHanHD != null && dmthoihanhd.loaiHopDong != null)
                {

                    db.Entry(dmthoihanhd).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Message_DanhMuc"] = "Cập nhật thành công!";
                    return RedirectToAction("Index_dmThoiHanHD", "DanhMuc");
                }
            }
            TempData["Message_DanhMuc"] = "Cập nhật thất bại!";
            return RedirectToAction("Index_dmThoiHanHD", "DanhMuc");
        }

        //
        // GET: /DanhMuc/ThoiGioLamViec

        public ActionResult Index_dmThoiGioLamViec()
        {
            return View(db.dmThoiGioLamViec.ToList());
        }
        
        //
        // POST: /DanhMuc/Create/ThoiGioLamViec

        [HttpPost]
        public ActionResult Create_dmThoiGioLamViec(dmThoiGioLamViec dmthoigiolamviec)
        {
            if (ModelState.IsValid)
            {
                db.dmThoiGioLamViec.Add(dmthoigiolamviec);
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Thêm mới thành công!";
                return RedirectToAction("Index_dmThoiGioLamViec", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Thêm mới thất bại!";
            return RedirectToAction("Index_dmThoiGioLamViec", "DanhMuc");
        }
        //
        // POST: /DanhMuc/Edit/5

        [HttpPost]
        public ActionResult Edit_dmThoiGioLamViec(dmThoiGioLamViec dmthoigiolamviec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmthoigiolamviec).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Cập nhật thành công!";
                return RedirectToAction("Index_dmThoiGioLamViec", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Cập nhật thất bại!";
            return RedirectToAction("Index_dmThoiGioLamViec", "DanhMuc");
        }

        //
        // GET: /DanhMuc/LoaiHopDong

        public ActionResult Index_dmLoaiHopDong()
        {
            return View(db.dmLoaiHopDong.ToList());
        }

        //
        // POST: /DanhMuc/Create/LoaiHopDong

        [HttpPost]
        public ActionResult Create_dmLoaiHopDong(dmLoaiHopDong dmloaihopdong)
        {
            if (ModelState.IsValid)
            {
                db.dmLoaiHopDong.Add(dmloaihopdong);
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Thêm mới thành công!";
                return RedirectToAction("Index_dmLoaiHopDong", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Thêm mới thất bại!";
            return RedirectToAction("Index_dmLoaiHopDong", "DanhMuc");
        }
        //
        // POST: /DanhMuc/Edit/5

        [HttpPost]
        public ActionResult Edit_dmLoaiHopDong(dmLoaiHopDong dmloaihopdong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmloaihopdong).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Cập nhật thành công!";
                return RedirectToAction("Index_dmLoaiHopDong", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Cập nhật thất bại!";
            return RedirectToAction("Index_dmLoaiHopDong", "DanhMuc");
        }

        public ActionResult Delete_dmLoaiHopDong(int id)
        {
            db.dmLoaiHopDong.Remove(db.dmLoaiHopDong.Find(id));
            db.SaveChanges();
            TempData["Message_DanhMuc"] = "Xóa thành công!";
            return RedirectToAction("Index_dmLoaiHopDong", "DanhMuc");
        }

        //
        // GET: /DanhMuc/MauHopDong

        public ActionResult Index_dmMauHopDong()
        {
            return View(db.dmMauHopDong.ToList());
        }

        //
        // POST: /DanhMuc/Create/MauHopDong

        [HttpPost]
        public ActionResult Create_dmMauHopDong(dmMauHopDong dmmauhopdong)
        {
            if (ModelState.IsValid)
            {
                dmmauhopdong.hdNoiDung = HttpUtility.HtmlDecode(dmmauhopdong.hdNoiDung);
                db.dmMauHopDong.Add(dmmauhopdong);
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Thêm mới thành công!";
                return RedirectToAction("Index_dmMauHopDong", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Thêm mới thất bại!";
            return RedirectToAction("Index_dmMauHopDong", "DanhMuc");
        }
        //
        // POST: /DanhMuc/Edit/5

        [HttpPost]
        public ActionResult Edit_dmMauHopDong(dmMauHopDong dmmauhopdong)
        {
            if (ModelState.IsValid)
            {
                dmmauhopdong.hdNoiDung = HttpUtility.HtmlDecode(dmmauhopdong.hdNoiDung);
                db.Entry(dmmauhopdong).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message_DanhMuc"] = "Cập nhật thành công!";
                return RedirectToAction("Index_dmMauHopDong", "DanhMuc");
            }
            TempData["Message_DanhMuc"] = "Cập nhật thất bại!";
            return RedirectToAction("Index_dmMauHopDong", "DanhMuc");
        }

        public ActionResult Delete_dmMauHopDong(int id)
        {
            db.dmMauHopDong.Remove(db.dmMauHopDong.Find(id));
            db.SaveChanges();
            TempData["Message_DanhMuc"] = "Xóa thành công!";
            return RedirectToAction("Index_dmMauHopDong", "DanhMuc");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}