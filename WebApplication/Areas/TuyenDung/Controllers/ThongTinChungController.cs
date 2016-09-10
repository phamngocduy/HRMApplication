using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;
using System.Data.Entity.Validation;

namespace HRM.TuyenDung.Controllers
{
    public class ThongTinChungController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /ThongTinChung/

        public ActionResult Index()
        {
            var tdttungcuviens = db.tdTTUngCuVien;
            return View(tdttungcuviens.ToList());
        }

        //
        // GET: /ThongTinChung/Details/5

        public ActionResult Details(int id = 0)
        {
            tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
            if (tdttungcuvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(id);
            return View(tdttungcuvien);
        }

        //
        // GET: /ThongTinChung/Create

        public ActionResult Create(int UV_id)
        {
            ViewBag.UngVien_id = UV_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UV_id);
            return View();
        }

        //
        // POST: /ThongTinChung/Create

        [HttpPost]
        public ActionResult Create(tdTTUngCuVien tdttungcuvien, tdTheDinhDanh tdthedinhdanh, tdNoiSinh tdnoisinh, tdThongTinLienHe tdthongtinlienhe)
        {
            if (ModelState.IsValid)
            {
                db.tdTTUngCuVien.Add(tdttungcuvien);
                db.SaveChanges();
                // create the dinh danh
                var ddmodel = new tdTheDinhDanh() { UngVien_id = tdttungcuvien.id, LoaiThe_id = tdthedinhdanh.LoaiThe_id,SoThe = tdthedinhdanh.SoThe,NgayCap = tdthedinhdanh.NgayCap,NoiCap_id = tdthedinhdanh.NoiCap_id, NgayHetHan = tdthedinhdanh.NgayHetHan};
                db.tdTheDinhDanh.Add(ddmodel);
                db.SaveChanges();
                // create noi sinh
                //var nsmodel = new tdNoiSinh() { UngVien_id = tdttungcuvien.id, QuocGia_id = tdnoisinh.QuocGia_id, TinhThanh_id = tdnoisinh.TinhThanh_id};
                tdnoisinh.UngVien_id = tdttungcuvien.id;
                db.tdNoiSinh.Add(tdnoisinh);
                db.SaveChanges();
                // create kiem tra hs
                var hsmodel = new tdKiemTraH() { UngVien_id = tdttungcuvien.id, DonXinViec = false, SoYeuLyLich = false, TheDinhDanh = false, SoHoKhau = false, GiayKhamSucKhoe = false, BangCapBangDiem = false, Hinh = false, GiayToKhac = false};
                db.tdKiemTraH.Add(hsmodel);
                db.SaveChanges();

                //// create bang cap
                //var bcmodel = new tdBangCap() { UngVien_id = tdttungcuvien.id};
                //db.tdBangCap.Add(bcmodel);
                //db.SaveChanges();

                // create thong tin lien he
                //var lhmodel = new tdThongTinLienHe() { UngVien_id = tdttungcuvien.id};
                tdthongtinlienhe.UngVien_id = tdttungcuvien.id;
                db.tdThongTinLienHe.Add(tdthongtinlienhe);
                db.SaveChanges();
                // create dia chi thuong tru
                var lhttmodel = new tdHoKhauThuongTru() { TTLienHe_id = tdthongtinlienhe.id };
                db.tdHoKhauThuongTru.Add(lhttmodel);
                // create dia chi lien lac
                var lhllmodel = new tdDiaChiLienLac() { TTLienHe_id = tdthongtinlienhe.id};
                db.tdDiaChiLienLac.Add(lhllmodel);
                db.SaveChanges();

                // create thong tin ung tuyen
                var utmodel = new tdThongTinUngTuyen() { UngVien_id = tdttungcuvien.id};
                db.tdThongTinUngTuyen.Add(utmodel);
                db.SaveChanges();


                //var qttdmodel = new tdQuaTrinhTuyenDung() { UngVien_id = tdttungcuvien.id };
                //db.tdQuaTrinhTuyenDung.Add(qttdmodel);
                //db.SaveChanges();
                //var qllhmodel = new tdXemVaXepLichHen() { UngCuVien_id = tdttungcuvien.id, DaBaoChoUngCuVien = false};
                //db.tdXemVaXepLichHen.Add(qllhmodel);
                //db.SaveChanges();
                //return RedirectToAction("Create","TuyenDung", new { tab = "ThongTinBangCap", UV_id = tdttungcuvien.id });
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinBangCap", nat = "Edit", id = tdttungcuvien.id });
            }
            return View(tdttungcuvien);
        }

        //
        // GET: /ThongTinChung/Edit/5

        public ActionResult Edit(int UV_id = 0)
        {
            tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(UV_id);
            if (tdttungcuvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = UV_id;
            return View(tdttungcuvien);
        }

        //
        // POST: /ThongTinChung/Edit/5

        [HttpPost]
        public ActionResult Edit(tdTTUngCuVien tdttungcuvien, tdNoiSinh tdnoisinh, tdTheDinhDanh tdthedinhdanh, tdBangCap tdbangcap)
        {
            try
            {
                // edit thong tin chung
                db.Entry(tdttungcuvien).State = EntityState.Modified;
                db.SaveChanges();
                // edit noi sinh
                var nssub = tdnoisinh;
                var nsold = db.tdNoiSinh.Where(ns => ns.UngVien_id == tdttungcuvien.id).First();
                tdnoisinh = new tdNoiSinh { id = nsold.id, UngVien_id = tdttungcuvien.id, QuocGia_id = nssub.QuocGia_id, TinhThanh_id = nssub.TinhThanh_id };
                db.Entry(nsold).CurrentValues.SetValues(tdnoisinh);
                db.Entry(nsold).State = EntityState.Modified;
                db.SaveChanges();
                // edit the dinh danh
                var sub = tdthedinhdanh;
                var old = db.tdTheDinhDanh.Where(dd => dd.UngVien_id == tdttungcuvien.id).First();
                tdthedinhdanh = new tdTheDinhDanh { id = old.id, UngVien_id = tdttungcuvien.id, LoaiThe_id = sub.LoaiThe_id, SoThe = sub.SoThe, NgayCap = sub.NgayCap, NoiCap_id = sub.NoiCap_id, NgayHetHan = sub.NgayHetHan };
                db.Entry(old).CurrentValues.SetValues(tdthedinhdanh);
                db.Entry(old).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinChung", nat = "Edit", id = tdttungcuvien.id });
            }
            catch
            {
                if (Request.Form[0] == "")
                {
                    var newtdbc = new tdBangCap { UngVien_id = tdbangcap.UngVien_id };
                    db.SaveChanges();
                    return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinChung", nat = "Edit", id = tdbangcap.UngVien_id });
                }
                else
                {
                    tdbangcap.id = int.Parse(Request.Form[0]);
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
                    db.Entry(tdbangcap).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinChung", nat = "Edit", id = tdbangcap.UngVien_id });
                }
            }
            return View(tdttungcuvien);
        }

        ////
        //// GET: /ThongTinChung/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
        //    if (tdttungcuvien == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdttungcuvien);
        //}

        ////
        //// POST: /ThongTinChung/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
        //    db.tdTTUngCuVien.Remove(tdttungcuvien);
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