using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLBHXH.Models;
using System.Web.Script.Serialization;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace HRM.QLBHXH.Controllers
{
    public class NhanVienBHXHController : Controller
    {
 
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /NhanVienBHXH/

        public ActionResult Index()
        {

            return View();
        }

      




        //
        // GET: /NhanVienBHXH/Details/5

        public ActionResult Details(int id = 0)
        {
            nvbhNhanVienBHXH nvbhnhanvienbhxh = db.nvbhNhanVienBHXH.Find(id);

            return View(nvbhnhanvienbhxh);
        }




        public ActionResult Index2()
        {
            ViewBag.RowsAffected = db.Database.ExecuteSqlCommand("exec [auto_nam_BHXH]");
            //SqlCommand cmd = new SqlCommand(
       

            var donvi = db.nvbhNhanVienBHXH.Select(m => new { m.Donvi_id, m.DonVi }).Distinct().ToList();
            ViewBag.dsdonvi = new SelectList(donvi, "Donvi_id", "DonVi");
            var nvbhNhanVienBHXH = from ds in db.v_nvbhNhanVienBHXH.OrderBy(t=>t.ThangNghiTS) select ds  ;
            return View(nvbhNhanVienBHXH.ToList());
        }


        //
        // GET: /NhanVienBHXH/Create

        public PartialViewResult Create()
        {

            using (var nv = new HRM.Databases.Models.HRMDBEntities())
            {
                var donvi = nv.dmDonVi.ToList();
                var nhanvien = nv.nvSoYeuLyLich.ToList();

                ViewBag.dsdonvi = new SelectList(donvi, "id", "tenDonVi");
                ViewBag.nhanvien = new SelectList(nhanvien, "id", "hovaten");

            }
            return PartialView();
        }


        //danh sach nhan vien de su dung khi chon dv se xuat hien ten nv
        public string nvds(int idDonVi)
        {
            using (var nv = new HRM.Databases.Models.HRMDBEntities())
                return new JavaScriptSerializer().Serialize(
                                (from y in nv.nvSoYeuLyLich.ToList()
                                join n in nv.NhanVien.ToList() on y.NV_id equals n.id
                                join q in nv.nvQTLamViec.ToList() on n.id equals q.NV_id
                                join d in nv.dmDonVi.ToList() on q.DonVi_id equals d.id
                                where q.DonVi_id == idDonVi && q.ThoiGianKetThuc == null
                                orderby y.HoVaTen
                                select new { value =n.MaNV+"-"+y.NV_id, key = y.HoVaTen }).Distinct());
        }

        //
        // POST: /NhanVienBHXH/Create

        [HttpPost]
        public ActionResult Create(nvbhNhanVienBHXH nvbhnhanvienbhxh)
        {
            string manv = nvbhnhanvienbhxh.MANV;
                
            using (var nv = new HRM.Databases.Models.HRMDBEntities())
            {


                try
                {

                    if (db.nvbhNhanVienBHXH.FirstOrDefault(dsma => (dsma.MANV == manv)) != null)
                    {
                        TempData["Message"] = "Nhân viên này đã tồn tại";
                        return RedirectToAction("Index2", "NhanVienBHXH", new {dv =db.nvbhNhanVienBHXH.FirstOrDefault().Donvi_id});
                    }
                    else
                    {



                        if (ModelState.IsValid)
                        {


                            //lay cac thong tin cua nhan vien trong db cua HRM0
                            int idnv = (from h in nv.NhanVien
                                        where h.MaNV == manv
                                        select h.id).First();

                            var thongtinnv = (from nhanvien in nv.nvSoYeuLyLich
                                              where nhanvien.NV_id == idnv
                                              select nhanvien).First();
                            string gioitinh = (from gt in nv.dmGioiTinh
                                               where thongtinnv.GioiTinh_id == gt.id
                                               select gt.maGioiTinh).First();

                            string diachi = (from dc in nv.nvDiaChiNha
                                             where thongtinnv.HoKhauThuongTru_id == dc.id
                                             select dc.DiaChi).First();

                            //

                            DateTime ngaysinh = Convert.ToDateTime(thongtinnv.NgaySinh);
                            nvbhnhanvienbhxh.HoVaTen = thongtinnv.HoVaTen;
                            nvbhnhanvienbhxh.DiaChiTT = diachi;
                            nvbhnhanvienbhxh.ChucDanh = thongtinnv.ChucVuHienTai;
                            nvbhnhanvienbhxh.NgaySinh = ngaysinh;
                            if (gioitinh == "F") { nvbhnhanvienbhxh.Nu = true; }
                            else { nvbhnhanvienbhxh.Nu = false; }



                            db.nvbhNhanVienBHXH.Add(nvbhnhanvienbhxh);
                            db.SaveChanges();
                            TempData["Message"] = "Thêm mới nhân viên BHXH thành công";
                            return RedirectToAction("Index2", "NhanVienBHXH");
                        }

                    }
                }
                catch (Exception e)
                {
                    TempData["Message"] = "Thêm mới nhân viên BHXH không thành công";
                }

            }
            return View(nvbhnhanvienbhxh);

        }



        //kiem tra ton tai manv
        public static void UpdateModel(ModelStateDictionary ModelState, nvbhNhanVienBHXH nvbhnhanvienbhxh)
        {
            if (ModelState.IsValid)
            {
                nvbhnhanvienbhxh.MANV = nvbhnhanvienbhxh.MANV.Trim();

                using (var db = new HRMDB1Entities())
                {
                    //neu trong db da ton tai nhanvien vua moi chon thi thong bao
                    if (db.nvbhNhanVienBHXH.FirstOrDefault(nv => (nv.MANV == nvbhnhanvienbhxh.MANV)) != null)
                    {
                        ModelState.AddModelError("MANV", "Nhân viên này đã tồn tại trong danh sách nhân viên BHXH");

                    }
                }

            }

        }

        //
        // GET: /NhanVienBHXH/Edit/5

        public PartialViewResult Edit(int id = 0)
        {


            using (var nv = new HRM.Databases.Models.HRMDBEntities())
            {
                var donvi = nv.dmDonVi.ToList();
                ViewBag.dsdonvi = new SelectList(donvi, "tenDonVi", "tenDonVi");
            }
         var tnbhxh = (from l1 in db.nvbhNhanVienBHXH where l1.id == id select l1.sonamBHXH ?? 0).FirstOrDefault();
         var ttbhxh = (from l1 in db.nvbhNhanVienBHXH where l1.id == id select l1.sothangBHXH ?? 0).FirstOrDefault();
         var tnbhtn = (from l1 in db.nvbhNhanVienBHXH where l1.id == id select l1.sonamBHTN ?? 0).FirstOrDefault();
         var ttbhtn = (from l1 in db.nvbhNhanVienBHXH where l1.id == id select l1.sothangBHTN ?? 0).FirstOrDefault();


         ViewBag.tnbhxh = tnbhxh;
         ViewBag.ttbhxh = ttbhxh;
         ViewBag.tnbhtn = tnbhtn;
         ViewBag.ttbhtn = ttbhtn;

         
          


            ViewBag.dmkcb = from l in db.dmNoiKCB.AsEnumerable() select new SelectListItem { Value = l.id.ToString() + "-" + l.MaBV, Text = l.TenBV };

            ViewBag.idnv = id;
            nvbhNhanVienBHXH nvbhnhanvienbhxh = db.nvbhNhanVienBHXH.Find(id);
            //if (nvbhnhanvienbhxh == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhnhanvienbhxh);
        }

        //
        // POST: /NhanVienBHXH/Edit/5

        [HttpPost]
        public ActionResult Edit(nvbhNhanVienBHXH nvbhnhanvienbhxh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(nvbhnhanvienbhxh).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Message"] = "Sửa nhân viên BHXH thành công";
                    return RedirectToAction("Index2", "NhanVienBHXH");
                  
                }
            }
            catch { TempData["Message"] = "Sửa nhân viên BHXH không thành công"; }
            return View(nvbhnhanvienbhxh);
        }

        //
        // GET: /NhanVienBHXH/Delete/5

        public PartialViewResult Delete(int id = 0)
        {

            ViewBag.idnv = id;
            nvbhNhanVienBHXH nvbhnhanvienbhxh = db.nvbhNhanVienBHXH.Find(id);
            //if (nvbhnhanvienbhxh == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhnhanvienbhxh);
        }

        //
        // POST: /NhanVienBHXH/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                nvbhNhanVienBHXH nvbhnhanvienbhxh = db.nvbhNhanVienBHXH.Find(id);
                db.nvbhNhanVienBHXH.Remove(nvbhnhanvienbhxh);
                db.SaveChanges();
                TempData["Message"] = "Xóa nhân viên BHXH thành công";
                return RedirectToAction("Index2", "NhanVienBHXH");

            }
            catch { TempData["Message"] = "Xóa nhân viên BHXH không thành công"; return RedirectToAction("Index2", "NhanVienBHXH"); }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}