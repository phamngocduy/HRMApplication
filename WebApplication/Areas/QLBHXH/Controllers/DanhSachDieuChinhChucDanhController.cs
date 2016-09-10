using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLBHXH.Models;
using System.Web.Script.Serialization;
using System.Globalization;


namespace HRM.QLBHXH.Controllers
{
    public class DanhSachDieuChinhChucDanhController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();
        private HRM.Databases.Models.HRMDBEntities db1 = new Databases.Models.HRMDBEntities();
    //    private HRM.Databases.Models.dmChucDanh db1 = new HRM.Databases.Models.dmChucDanh();
        //
        // GET: /DanhSachDieuChinhChucDanh/

        public ActionResult Index()
        {
            var nvbhdanhsachdieuchinhchucdanhs = db.nvbhDanhSachDieuChinhChucDanh.Include(n => n.dmLoaiDieuChinh).Include(n => n.nvbhNhanVienBHXH);
            return View(nvbhdanhsachdieuchinhchucdanhs.ToList());
        }


        //su dung index2 de ap dung jquery slide
        public ActionResult Index2(string BD = "")
        {
            int maxId = (from c in db.nvbhDanhSachDieuChinhTangGiam select c.MoiNhat).Max();
            ViewBag.idmoi = maxId;
            
            var nvbhdanhsachdieuchinhchucdanhs = from ds in db.v_ChucDanh select ds;
            int NgayHT = DateTime.Now.Day;
            int ThangHT = DateTime.Now.Month;
            int NamHT = DateTime.Now.Year;
            int thang = ThangHT;
            string DotCuaThang = ""; 



            int thang1 = 1;
            int nam1 = 1;
            string ngaybd1 = "01/01/2014";
            string ngaykt1 = "01/01/2014";

            if (BD != "")
            {

                //int thanght=1, namht=1;
                thang1 = int.Parse(BD.Substring(0, 2));
                nam1 = int.Parse(BD.Substring(3, 4));
                DotCuaThang = thang1.ToString("D2") + "/" + nam1;
            }
            else
            {

                if (BD == "")
                {
                    thang1 = ThangHT;
                    nam1 = NamHT;
                    DotCuaThang = ThangHT.ToString("D2") + "/" + NamHT;
                }
            }
            switch (thang1)
            {
                case 1: ngaybd1 = "12/21/" + (nam1 - 1); ngaykt1 = "01/20/" + nam1; break;
                case 2: ngaybd1 = "01/21/" + nam1; ngaykt1 = "02/20/" + nam1; break;
                case 3: ngaybd1 = "02/21/" + nam1; ngaykt1 = "03/20/" + nam1; break;
                case 4: ngaybd1 = "03/21/" + nam1; ngaykt1 = "04/20/" + nam1; break;
                case 5: ngaybd1 = "04/21/" + nam1; ngaykt1 = "05/20/" + nam1; break;
                case 6: ngaybd1 = "05/21/" + nam1; ngaykt1 = "06/20/" + nam1; break;
                case 7: ngaybd1 = "06/21/" + (nam1); ngaykt1 = "07/20/" + nam1; break;
                case 8: ngaybd1 = "07/21/" + nam1; ngaykt1 = "08/20/" + nam1; break;
                case 9: ngaybd1 = "08/21/" + nam1; ngaykt1 = "09/20/" + nam1; break;
                case 10: ngaybd1 = "09/21/" + nam1; ngaykt1 = "10/20/" + nam1; break;
                case 11: ngaybd1 = "10/21/" + nam1; ngaykt1 = "11/20/" + nam1; break;
                case 12: ngaybd1 = "11/21/" + nam1; ngaykt1 = "12/20/" + (nam1 + 1); break;
            }

            DateTime start = DateTime.ParseExact(ngaybd1, "MM/dd/yyyy", CultureInfo.CurrentCulture);
            DateTime end = DateTime.ParseExact(ngaykt1, "MM/dd/yyyy", CultureInfo.CurrentCulture);
            ViewBag.NgayBD = ngaybd1;

            ViewBag.NgayKT = ngaykt1;
            TempData["startdate"] = ngaybd1;
            TempData["enddate"] = ngaykt1;

            nvbhdanhsachdieuchinhchucdanhs = from ds in db.v_ChucDanh where ds.idLoaiDieuChinh == 9 && start <= ds.TuThangNam && ds.TuThangNam <= end select ds;

            ViewBag.Dot = DotCuaThang;
            //var count = from ds in db.v_nvbhDanhSachDieuChinhTangGiam where start <= ds.NgayPhatSinh && ds.NgayPhatSinh <= end && ds.XacNhan == false select ds;
            //TempData["count"] = count.Count();
            return View(nvbhdanhsachdieuchinhchucdanhs.ToList());
        }

        //
        // GET: /DanhSachDieuChinhChucDanh/Details/5

        public ActionResult Details(int id = 0)
        {
            nvbhDanhSachDieuChinhChucDanh nvbhdanhsachdieuchinhchucdanh = db.nvbhDanhSachDieuChinhChucDanh.Find(id);
            if (nvbhdanhsachdieuchinhchucdanh == null)
            {
                return HttpNotFound();
            }
            return View(nvbhdanhsachdieuchinhchucdanh);
        }

        //
        // GET: /DanhSachDieuChinhChucDanh/Create

        public PartialViewResult Create()
        {



            ViewBag.idLoaiDieuChinh = new SelectList(db.dmLoaiDieuChinh, "id", "LoaiDieuChinh");
            HRM.Databases.Models.dmChucDanh cd1 = new Databases.Models.dmChucDanh();
        
          var dv = db.nvbhNhanVienBHXH.Select(m => new { m.Donvi_id, m.DonVi }).Distinct().ToList();
          ViewBag.dsdonvi = new SelectList(dv, "Donvi_id", "DonVi");
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "NV_id", "HoVaTen");
            //DateTime ngayht = DateTime.Now.Date;
            //ViewBag.ngayht = ngayht;
            return PartialView();
        }


        //danh sach nhan vien de su dung khi chon dv se xuat hien ten nv
        public string nvds(int dvid)
        {
                return new JavaScriptSerializer().Serialize(
                                from y in db.nvbhNhanVienBHXH
                                where y.Donvi_id==dvid

                                select new { value = y.NV_id, key = y.HoVaTen });
        }


        //
        // POST: /DanhSachDieuChinhChucDanh/Create

        [HttpPost]
        public ActionResult Create(nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhchucdanh)
        {
            if (ModelState.IsValid)
            {
                db.nvbhDanhSachDieuChinhTangGiam.Add(nvbhdanhsachdieuchinhchucdanh);
                db.SaveChanges();
                TempData["Message"] = "Thêm thành công";
                return RedirectToAction("Index2");
            }
            else
            {
                TempData["Message"] = "Thêm không thành công";
                return RedirectToAction("Index2");
            }

            return View(nvbhdanhsachdieuchinhchucdanh);
        }

        //
        // GET: /DanhSachDieuChinhChucDanh/Edit/5

        public ActionResult Edit(int id = 0)
        {
            nvbhDanhSachDieuChinhChucDanh nvbhdanhsachdieuchinhchucdanh = db.nvbhDanhSachDieuChinhChucDanh.Find(id);
            if (nvbhdanhsachdieuchinhchucdanh == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLoaiDieuChinh = new SelectList(db.dmLoaiDieuChinh, "id", "LoaiDieuChinh", nvbhdanhsachdieuchinhchucdanh.idLoaiDieuChinh);
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhdanhsachdieuchinhchucdanh.idnvbhNhanVienBHXH);
            return View(nvbhdanhsachdieuchinhchucdanh);
        }

        //
        // POST: /DanhSachDieuChinhChucDanh/Edit/5

        [HttpPost]
        public ActionResult Edit(nvbhDanhSachDieuChinhChucDanh nvbhdanhsachdieuchinhchucdanh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvbhdanhsachdieuchinhchucdanh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idLoaiDieuChinh = new SelectList(db.dmLoaiDieuChinh, "id", "LoaiDieuChinh", nvbhdanhsachdieuchinhchucdanh.idLoaiDieuChinh);
            ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen", nvbhdanhsachdieuchinhchucdanh.idnvbhNhanVienBHXH);
            return View(nvbhdanhsachdieuchinhchucdanh);
        }

        //
        // GET: /DanhSachDieuChinhChucDanh/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);

            ViewBag.hovaten = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.HoVaTen;
            ViewBag.manv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.MANV;
            ViewBag.sobh = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.SoBHXH;
           
            
            //if (nvbhdanhsachdieuchinhchucdanh == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhdanhsachdieuchinhtanggiam);
        }


        // GET: /Qua Trinh

        public PartialViewResult QuaTrinh(int id = 0)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
            ViewBag.Manv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.MANV;
            ViewBag.tennv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.HoVaTen;
            return PartialView(nvbhdanhsachdieuchinhtanggiam);
        }

        //
        // POST: /Qua Trinh

        [HttpPost]
        public ActionResult QuaTrinh(nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam)
        {
            if (ModelState.IsValid)
            {
                nvbhdanhsachdieuchinhtanggiam.XacNhan = true;
                db.Entry(nvbhdanhsachdieuchinhtanggiam).State = EntityState.Modified;
                db.SaveChanges();


                TempData["Message"] = "Đưa vào quá trình thành công";
            }
            return RedirectToAction("Index2");
        }

        //
        // POST: /DanhSachDieuChinhChucDanh/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
            db.nvbhDanhSachDieuChinhTangGiam.Remove(nvbhdanhsachdieuchinhtanggiam);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}