using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using System.Web.Script.Serialization;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class nvQTHocTapController : HoSoController
    {
        private HRMDBEntities db = new HRMDBEntities();

        public ActionResult Index()
        {
            ViewBag.DB = db;
            var xeploai = db.dmXepLoaiTotNghiep.Select(m => new { m.id, m.tenXepLoaiTotNghiep }).Distinct().ToList();
            xeploai.Add(new { id=5, tenXepLoaiTotNghiep="---" });
            ViewBag.xeploai = new SelectList(xeploai, "id", "tenXepLoaiTotNghiep");
            var model = TempData["Model"];
            var model1 = TempData["Model1"];
            return View(model != null ? model : new nvQTHocTap());
        }
        //public static int themBangCap(int nv_id, int loaibangcap, int danhhieu, string tentruong, int chuyennganh, string tenchuyennganh, int loaihinh, DateTime ngaytn, int xeploai, string ghichu, int noihoc, int quocgia, int hotro)
        //{
        //    using (var db = new HRMDBEntities())
        //    {
               
        //        var bc = new nvBangCap
        //        {
        //            NV_id = nv_id,
        //            LoaiBangCap_id = loaibangcap,
        //            DanhHieu_id = danhhieu,
        //            TenTruong = tentruong,
        //            ChuyenNganh_id = chuyennganh,
        //            ChuyenNganh= tenchuyennganh, 
        //            LoaiHinhDaoTao_id = loaihinh,
        //            NgayTN = ngaytn,
        //            XepLoaiTotNghiep_id = xeploai,
        //            GhiChu = ghichu,
        //            QuocGia_id= quocgia,
        //            NoiHoc_id=noihoc,
        //            HoTro=hotro,
        //            SauKhiVeTruong=true,
        //            Xoa=false
        //        };

        //        db.nvBangCap.Add(bc);
        //        db.SaveChanges();
        //        return bc.id;
        //    }
        //}
        public ActionResult qtChungChi()
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return View(model != null ? model : new nvQTChungChi());
        }
        public ActionResult dsNhanVien(bool all = false)
        {
            return View(all ? db.NhanViens.All.ToList() : db.NhanVien.ToList());
        }
        public ActionResult Canhan(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            return View(model != null ? model : new nvQTHocTap(){NV_id=id});
        }

        //
        // GET: /nvQTHocTap/Details/5

        public ActionResult Details(int id = 0)
        {
            nvQTHocTap nvqthoctap = db.nvQTHocTap.Find(id);
            if (nvqthoctap == null)
            {
                return HttpNotFound();
            }
            return View(nvqthoctap);
        }
        public void Delete(int id)
        {
            nvQTHocTap nvqthoctap = db.nvQTHocTap.Find(id);
            // db.nvBangCap.Remove(model);
//            nvqthoctap.Xoa = true;
            db.SaveChanges();
            TempData["Message"] = "CapNhatThanhCong";
        }
        public void LoaiKhoiDanhSach(int id)
        {
            nvQTHocTap nvqthoctap = db.nvQTHocTap.Find(id);
           // nvqthoctap.HienThi = false;
            db.SaveChanges();
        }


        [HttpPost]
        public ActionResult Update( int? HT_id)
        {
          //  ModelState.Clear();
            var model = HT_id.HasValue ? db.nvQTHocTap.Find(HT_id) : new nvQTHocTap();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !HT_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!HT_id.HasValue)
                {
                    //check db khi deploy
                    if (!model.QuocGia_id.HasValue)
                        model.QuocGia_id = 1;
                    if (!model.XepLoaiTotNghiep_id.HasValue)
                        model.XepLoaiTotNghiep_id = 4;
                    if (!model.HienTrang_id.HasValue)
                        model.HienTrang_id = 1;
                    db.nvQTHocTap.Add(model);
                }
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                if(model.KetThucChinhThuc.HasValue)
                try
                {

                    int tmp = 0;
                   tmp= db.nvBangCap.Where(m => m.HoTro == model.id).Select(m=>m.id).FirstOrDefault();
                   nvBangCap bc = db.nvBangCap.Find(tmp);
                    if (tmp!=0)
                    {
                        bc.Xoa = false;
                        db.SaveChanges();
                    }
                    else
                        themBangCap(Convert.ToInt32(model.NV_id), Convert.ToInt32(model.LoaiBangCap_id), 1, model.TenTruong, Convert.ToInt32(model.ChuyenNganh_id), model.ChuyenNganh, Convert.ToInt32(model.LoaiHinhDaoTao_id), Convert.ToDateTime(model.KetThucChinhThuc), Convert.ToInt32(model.XepLoaiTotNghiep_id), false, model.GhiChu, Convert.ToInt32(model.NoiHoc_id), Convert.ToInt32(model.QuocGia_id), false, model.id);
                }
                catch { }
           
                TempData["Message"] = "Thành công";
            }
            else
                TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update_CC(int? CC_id)
        {
            //  ModelState.Clear();
            var model = CC_id.HasValue ? db.nvQTChungChi.Find(CC_id) : new nvQTChungChi();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !CC_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!CC_id.HasValue) db.nvQTChungChi.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                if (model.ThoiGianKetThucChinhThuc.HasValue)                   
                        themchungchi(Convert.ToInt32(model.NV_id), Convert.ToInt32(model.LoaiChungChi_id), model.KetQua, model.TenTruong, Convert.ToDateTime(model.ThoiGianKetThucChinhThuc), model.GhiChu, model.id);
                TempData["Message"] = "Thành công";
            }
            else
                TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("qtChungChi");
        }
        private int themBangCap(int nv_id, int loaibangcap_id, int danhhieu_id, string tentruong, int chuyennganh_id, string chuyennganh, int loaihinhdaotao_id, DateTime ngaytn, int xeploaitotnghiep_id, bool chuyennganhchinh, string ghichu, int noihoc_id, int quocgia_id, bool danhhieuchinh, int hotro )
        {
            using (var db = new HRMDBEntities())
            {
              //check danh hieu cho từng loại db
                int danhhieu = 0;
                switch (loaibangcap_id)
                {
                    case 1:
                        danhhieu = 3;
                        break;
                    case 2:
                        danhhieu = 1;
                        break;
                    case 3:
                        danhhieu = 7;
                        break;
                    case 4:
                        danhhieu = 8;
                        break;
                    case 5:
                        danhhieu = 9;
                        break;
                    case 6:
                        break;
                    case 7:
                        danhhieu = 2;
                        break;
                    default:
                        break;
                }
                var tv = new nvBangCap
                {
                    NV_id=nv_id,
                    LoaiBangCap_id=loaibangcap_id,
                    DanhHieu_id = danhhieu,
                    TenTruong=tentruong,
                    ChuyenNganh_id=chuyennganh_id,
                    ChuyenNganh=chuyennganh,
                    LoaiHinhDaoTao_id=loaibangcap_id,
                    NgayTN=ngaytn,
                    XepLoaiTotNghiep_id=xeploaitotnghiep_id,
                    ChuyenNganhChinh=chuyennganhchinh,
                    GhiChu=ghichu,
                    NoiHoc_id=noihoc_id,
                    QuocGia_id=quocgia_id,
                    DanhHieuChinh=danhhieuchinh,
                    HoTro=hotro,
                    Xoa=false,
                    SauKhiVeTruong=true
                };

                db.nvBangCap.Add(tv);
                db.SaveChanges();
                return tv.id;
            }
        }
        private int themchungchi(int nv_id, int loaichungchi_id,string capdo, string noicap, DateTime ngaycap, string ghichu, int hotro)
        {
            using (var db = new HRMDBEntities())
            {

                var tv = new ChungChi
                {
                    NV_id = nv_id,
                    LoaiChungChi_id = loaichungchi_id,
                    Capdo=capdo,
                    NoiCap = noicap,
                    NgayCap = ngaycap,
                    GhiChu=ghichu,
                    HoTro=hotro,
                    SauKhiVeTruong = true                    
                };

                db.ChungChi.Add(tv);
                db.SaveChanges();
                return tv.id;
            }
        }
        //[HttpPost]
        //public ActionResult Edit(nvQTHocTap nvqthoctap)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(nvqthoctap).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.ChuyenNganh_id = new SelectList(db.dmChuyenNganh, "id", "MaChuyenNganh", nvqthoctap.ChuyenNganh_id);
        //    ViewBag.HienTrang_id = new SelectList(db.dmHienTrangDiHoc, "id", "MaHienTrang", nvqthoctap.HienTrang_id);
        //    ViewBag.LoaiBangCap_id = new SelectList(db.dmLoaiBangCap, "id", "MaLoaiBangCap", nvqthoctap.LoaiBangCap_id);
        //    ViewBag.LoaiHinhDaoTao_id = new SelectList(db.dmLoaiHinhDaoTao, "id", "MaLoaiHinhDaoTao", nvqthoctap.LoaiHinhDaoTao_id);
        //    ViewBag.LoaiKhoaHoc_id = new SelectList(db.dmLoaiKhoaHoc, "id", "MaLoaiKhoaHoc", nvqthoctap.LoaiKhoaHoc_id);
        //    ViewBag.NoiHoc_id = new SelectList(db.dmNoiHoc, "id", "MaNoiHoc", nvqthoctap.NoiHoc_id);
        //    ViewBag.QuocGia_id = new SelectList(db.dmQuocGia, "id", "maQuocGia", nvqthoctap.QuocGia_id);
        //    ViewBag.XepLoaiTotNghiep_id = new SelectList(db.dmXepLoaiTotNghiep, "id", "MaLoaiTotNghiep", nvqthoctap.XepLoaiTotNghiep_id);
        //    ViewBag.NV_id = new SelectList(db.NhanVien, "id", "MaHS", nvqthoctap.NV_id);
        //    return View(nvqthoctap);
        //}
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            nvQTHocTap nvqthoctap = db.nvQTHocTap.Find(id);
//            nvqthoctap.Xoa = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public string DSNV(int idDonVi)
        {
            return new JavaScriptSerializer().Serialize(
               (from c in db.NhanVien
                join d in db.nvQTLamViec on c.id equals d.NV_id 
                where d.DonVi_id == idDonVi && !d.ThoiGianKetThuc.HasValue && !c.ngayNghiViec.HasValue
                select new { value = c.id, key = c.nvSoYeuLyLiches.Single().HoVaTen }).Distinct());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult IndexBC(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            var cn1 = (from x in db.dmChuyenNganh
                       select x);
            ViewBag.cn1 = new SelectList(cn1, "id", "tenchuyennganh");
            try
            {
                var a = (from x in db.nvQTHocTap
                         join c in db.dmChuyenNganh on x.ChuyenNganh_id equals c.id
//                         where x.ChuyenNganhChinh == true && x.NV_id == id
                         select x.dmChuyenNganh.tenChuyenNganh).SingleOrDefault();
                var b = (from x in db.nvQTHocTap
                         join c in db.dmLoaiBangCap on x.LoaiBangCap_id equals c.id
                         where x.NV_id == id
                         orderby c.stt
                         select x.dmLoaiBangCap.tenLoaiBangCap).First();
                ViewBag.trinhdo = b;
                ViewBag.chuyennganh = a;
            }
            catch { }
            return PartialView(model != null ? model : new nvQTHocTap() { NV_id = id });
        }


        [HttpPost]
        public ActionResult UpdateBC(int? BC_id)
        {
            var model = BC_id.HasValue ? db.nvQTHocTap.Find(BC_id) : new nvQTHocTap();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !BC_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!BC_id.HasValue) db.nvQTHocTap.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Thành công";
            }
            else
                TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        }
        public ActionResult capNhatChuyenNganh(int id)
        {
            var model = db.nvQTHocTap.Find(id);
            //  var nvid= from p in db.nvBangCap where p.id==id select p.NV_id;
            //   int mt = Convert.ToInt32(nvid);
            var tmp = from p in db.nvQTHocTap where p.NV_id == (from k in db.nvQTHocTap where k.id == id select k.NV_id).FirstOrDefault() select p;
            foreach (var nv in tmp)
            {
//                nv.ChuyenNganhChinh = false;
                //      db.SaveChanges();
            }
//            model.ChuyenNganhChinh = true;
            db.SaveChanges();

            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        }
        //public ActionResult DeleteBC(int id)
        //{
        //    nvBangCap model = db.nvBangCap.Find(id);
        //    // db.nvBangCap.Remove(model);
        //    model.Xoa = true;
        //    db.SaveChanges();
        //    TempData["Message"] = "CapNhatThanhCong";
        //    return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        //}
        public string List(int CN_id)
        {
            return new JavaScriptSerializer().Serialize(
                db.dmChuyenNganh
                  .OrderBy(qh => qh.stt).AsEnumerable()
                  .Select(qh => new { key = qh.tenChuyenNganh, value = qh.id })
                );
        }
        //public new PartialViewResult IndexP(int NV_id)
        //{
        //    return base.IndexP(NV_id);
        //}
    }
}