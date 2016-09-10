using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLBHXH.Models;
using System.Globalization;
using System.Web.Script.Serialization;



namespace HRM.QLBHXH.Controllers
{
    public class DanhSachDieuChinhTangGiamController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //public ActionResult Filter1()
        //{
        //    return RedirectToAction("Index2", new { From = Request["From"], To = Request["To"], All = Request["All"] });
        //}


        public ActionResult D02TS()
        {
            return View();
        }


        //danh sach nhan vien de su dung khi chon dv se xuat hien ten nv
        public string nvds(int id)
        {

            return new JavaScriptSerializer().Serialize(
                            from nvbhxh in db.nvbhNhanVienBHXH

                            select nvbhxh.ChucDanh);
        }



        // GET: / DAnh sách điều chỉnh tăng giảm
        public ActionResult Index2(string BD = "")
        {
            int maxId = (from c in db.nvbhDanhSachDieuChinhTangGiam select c.MoiNhat).Max();
            ViewBag.idmoi = maxId;
            int idloaitg = (from t in db.nvbhDanhSachDieuChinhTangGiam where t.MoiNhat == maxId select t.idLoaiDieuChinh).First();
            string idldc = (from t in db.nvbhDanhSachDieuChinhTangGiam where t.MoiNhat == maxId select t.idLoaiTangGiam).First();
            ViewBag.moinhat = (from moi in db.nvbhDanhSachDieuChinhTangGiam where moi.MoiNhat == maxId select moi).Count();
            string loaitg = "";
            switch (idloaitg)
            {
                case 1:

                    switch (idldc)
                    {
                        case "TM": loaitg = "Tăng mới"; break;

                        case "AD": loaitg = "Tăng bổ sung"; break;
                        case "ON": loaitg = "Nghỉ đi làm lại"; break;
                    }
                    
                   ; break;

                case 2:

                    switch (idldc)
                    {
                        case "GH": loaitg = "Giảm hẳn"; break;

                        case "SB": loaitg = "Giảm nguyên lương"; break;
                        case "OF_1": loaitg = "Nghỉ ốm ngắn ngày/ nghỉ không lương/ không đủ đk hưởng chế độ thai sản"; break;
                        case "TS": loaitg = "Đủ điều kiện hưởng chế độ thai sản"; break;
                        case "OF_2": loaitg = "Nghỉ ốm dài hạn"; break;
                    }

                    ; break;

                case 3: loaitg = "Tăng mức đóng"; break;
                case 4: loaitg = "Giảm mức đóng"; break;
                case 5: loaitg = "Tăng bảo hiểm y tế"; break;
                case 6: loaitg = "Giảm bảo hiểm y tế"; break;
                case 7: loaitg = "Tăng bảo hiểm thất nghiệp"; break;
                case 8: loaitg = "Giảm bảo hiểm thất nghiệp"; break;
                case 9: loaitg = "Thay đổi chức danh"; break;

            }


            ViewBag.idloaitg = loaitg;








            var nvbhdanhsachdieuchinhtanggiams = from ds in db.v_nvbhDanhSachDieuChinhTangGiam1 select ds;//.Include(n => n.dmLoaiTangGiam).Include(n => n.nvbhNhanVienBHXH);
            int NgayHT = DateTime.Now.Day;
            int ThangHT = DateTime.Now.Month;
            //ViewBag.a = DateTime.Now.Month.ToString("D2");
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
                thang1 = int.Parse(BD.Substring(0, 2));
                nam1 = int.Parse(BD.Substring(3, 4));
                DotCuaThang = thang1.ToString("D2") + "/" + nam1;

            }
            else
            {

                if (BD == "")
                {
               

                    if (ThangHT < 12)
                    {
                        if (NgayHT <= 20) { thang1 = ThangHT; nam1 = NamHT; DotCuaThang = (thang1).ToString("D2") + "/" + nam1; }
                        else { if (NgayHT > 20) { thang1 = ThangHT + 1; nam1 = NamHT; DotCuaThang = (thang1).ToString("D2") + "/" + nam1; } }
                    }

                    else
                    {

                        if (ThangHT == 12)
                        {
                            if (NgayHT <= 20) { thang1 = ThangHT; nam1 = NamHT; DotCuaThang = (thang1).ToString("D2") + "/" + nam1; }
                            else { if (NgayHT > 20) { thang1 = 1; nam1 = NamHT + 1; DotCuaThang = (thang1).ToString("D2") + "/" + nam1; } }
                        }
                    }

                

                }
                   
                   
               

                
            }
            //"12/" + DateTime.DaysInMonth(nam1 - 1, 12) + "/(nam1 - 1)";
            switch (thang1)
            {
                case 1: ngaybd1 = "01/01/" + nam1; ngaykt1 = "01/" + DateTime.DaysInMonth(nam1 ,1) + "/"+nam1; break;
                case 2: ngaybd1 = "02/01/" + nam1; ngaykt1 = "02/" + DateTime.DaysInMonth(nam1, 2) + "/" + nam1; break;
                case 3: ngaybd1 = "03/01/" + nam1; ngaykt1 = "03/" + DateTime.DaysInMonth(nam1, 3) + "/" + nam1; break;
                case 4: ngaybd1 = "04/01/" + nam1; ngaykt1 = "04/" + DateTime.DaysInMonth(nam1, 4) + "/" + nam1; break;
                case 5: ngaybd1 = "05/01/" + nam1; ngaykt1 = "05/" + DateTime.DaysInMonth(nam1, 5) + "/" + nam1; break;
                case 6: ngaybd1 = "06/01/" + nam1; ngaykt1 = "06/" + DateTime.DaysInMonth(nam1,6) + "/" + nam1; break;
                case 7: ngaybd1 = "07/01/" + nam1; ngaykt1 = "07/" + DateTime.DaysInMonth(nam1, 7) + "/" + nam1; break;
                case 8: ngaybd1 = "08/01/" + nam1; ngaykt1 = "08/" + DateTime.DaysInMonth(nam1, 8) + "/" + nam1; break;
                case 9: ngaybd1 = "09/01/" + nam1; ngaykt1 = "09/" + DateTime.DaysInMonth(nam1, 9) + "/" + nam1; break;
                case 10: ngaybd1 = "10/01/" + nam1; ngaykt1 = "10/" + DateTime.DaysInMonth(nam1, 10) + "/" + nam1; break;
                case 11: ngaybd1 = "11/01/" + nam1; ngaykt1 = "11/" + DateTime.DaysInMonth(nam1, 11) + "/" + nam1; break;
                case 12: ngaybd1 = "12/01/" + nam1; ngaykt1 = "12/" + DateTime.DaysInMonth(nam1,12) + "/" + nam1; break;
            }


        
            DateTime start = DateTime.ParseExact(ngaybd1, "MM/dd/yyyy", CultureInfo.CurrentCulture);
            DateTime end = DateTime.ParseExact(ngaykt1, "MM/dd/yyyy", CultureInfo.CurrentCulture);
            ViewBag.NgayBD = ngaybd1;

            ViewBag.NgayKT = ngaykt1;
            TempData["startdate"] = ngaybd1;
            TempData["enddate"] = ngaykt1;

            nvbhdanhsachdieuchinhtanggiams = from ds in db.v_nvbhDanhSachDieuChinhTangGiam1.OrderByDescending(t=>t.MoiNhat) where   ds.idLoaiDieuChinh != 9 && (start <= ds.TuThangNam && ds.TuThangNam <= end) select ds;
            var count = from ds in db.v_nvbhDanhSachDieuChinhTangGiam1 where start <= ds.TuThangNam && ds.TuThangNam <= end && ds.XacNhan == false select ds;
            TempData["count"] = count.Count();
            //TempData["moinhat"] = moinhat +" "+ idloaitg;


            ViewBag.Dot = DotCuaThang;
            return View(nvbhdanhsachdieuchinhtanggiams.ToList());
        }


        //
        // GET: /DanhSachDieuChinhTangGiam/

        public ActionResult Index()
        {
            var nvbhdanhsachdieuchinhtanggiams = db.nvbhDanhSachDieuChinhTangGiam.Include(n => n.dmLoaiDieuChinh);//.Include(n => n.nvbhNhanVienBHXH);
            return View(nvbhdanhsachdieuchinhtanggiams);//.ToList());
        }

        //
        // GET: /DanhSachDieuChinhTangGiam/Details/5

        public PartialViewResult Details(int id = 0)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
            //if (nvbhdanhsachdieuchinhtanggiam == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhdanhsachdieuchinhtanggiam);
        }

        //
        // GET: /DanhSachDieuChinhTangGiam/Create

        public PartialViewResult Create()
        {

            string tlBHXH = (from bh in db.dmTyLeDongBHXH where bh.TrangThai == true select bh.TongBHXH).First();
            float tlBHXHint = float.Parse(tlBHXH, CultureInfo.InvariantCulture.NumberFormat);
            var tlBHYT = (from bh in db.dmTyLeDongBHXH where bh.TrangThai == true select bh.TongBHYT).First();
            //var tlBHYT1 = (from bh in db.dmTyLeDongBHXH where bh.TrangThai == true select bh.TongBHYT).First();
            float tlBYTHint = float.Parse(tlBHYT, CultureInfo.InvariantCulture.NumberFormat);
            var tlBHTN = (from bh in db.dmTyLeDongBHXH where bh.TrangThai == true select bh.TongBHTN).First();
            float tlBTNint = float.Parse(tlBHTN, CultureInfo.InvariantCulture.NumberFormat);
          

            List < SelectListItem > items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "3 loại - " + (tlBHXHint + tlBYTHint + tlBTNint).ToString(), Value = (tlBHXHint + tlBYTHint + tlBTNint).ToString(), Selected = false });
            items.Add(new SelectListItem() { Text = "2 loại - " + (tlBHXHint + tlBYTHint).ToString(), Value = (tlBHXHint + tlBYTHint).ToString(), Selected = true });
            items.Add(new SelectListItem() { Text = "BHTN - " + (tlBTNint).ToString(), Value = (tlBTNint).ToString(), Selected = false });
            items.Add(new SelectListItem() { Text = "BHYT - " + (tlBYTHint).ToString(), Value = (tlBYTHint).ToString(), Selected = false });

      




            DateTime ngayht = DateTime.Now.Date;
            ViewBag.ngayht = ngayht;
            //using (var db0 = new HRM.Databases.Models.HRMDBEntities())

            var ldc = from dc in db.dmLoaiDieuChinh where dc.id != 9 select dc;

            ViewBag.idLoaiDieuChinh = new SelectList(ldc, "id", "LoaiDieuChinh");
            ViewBag.idLoaiTangGiam = new SelectList(db.dmLoaiTangGiam.ToList(), "Ma", "Ma");
            ViewBag.TyLeDong = new SelectList(items, "Value", "Text");





            ViewBag.idnvbhNhanVienBHXH = new SelectList((from nv in db.nvbhNhanVienBHXH select new { NV_id = nv.NV_id, HoVaTen = nv.HoVaTen + " - " + nv.MANV }), "NV_id", "HoVaTen");

            ViewBag.nv1 = from nvbh in db.nvbhNhanVienBHXH select new SelectListItem { Value = nvbh.id.ToString(), Text = nvbh.HoVaTen };
            ViewBag.list = from l in db.nvbhNhanVienBHXH.AsEnumerable() select new SelectListItem { Value = l.NV_id.ToString() + "-" + l.ChucDanh, Text = l.HoVaTen + " - " + l.MANV };

            //ViewBag.idnvbhNhanVienBHXH = new SelectList(db.nvbhNhanVienBHXH, "id", "HoVaTen");
            return PartialView();
        }
        //
        // POST: /DanhSachDieuChinhTangGiam/Create


        //danh sach loai tang giam
        public string TG(int id)
        {

            return new JavaScriptSerializer().Serialize(

                  from tang in db.dmLoaiTangGiam
                  where tang.idLoaiDieuChinh == id

                  select new { value = tang.Ma, key = tang.Ma });
            //from y db.dmLoaiTangGiam 
            //select new { value = n.MaNV + "-" + y.NV_id, key = y.HoVaTen });
        }


        [HttpPost]
        public ActionResult Create(nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam)
        {
            if (ModelState.IsValid)
            {

                int maxId1 = (from c in db.nvbhDanhSachDieuChinhTangGiam select c.MoiNhat).Max();
                db.nvbhDanhSachDieuChinhTangGiam.Add(nvbhdanhsachdieuchinhtanggiam);
                nvbhdanhsachdieuchinhtanggiam.MoiNhat = maxId1 + 1;
                db.SaveChanges();
                TempData["Message"] = "Thêm thành công";
                return RedirectToAction("Index2");
            }
            else
            {
                TempData["Message"] = "Thêm không thành công";
                return RedirectToAction("Index2");
            }

            return View(nvbhdanhsachdieuchinhtanggiam);
        }

        //
        // GET: /DanhSachDieuChinhTangGiam/Edit/5

        public PartialViewResult Edit(int id = 0)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
            //if (nvbhdanhsachdieuchinhtanggiam == null)
            //{
            //    return HttpNotFound();
            //}


            //ViewBag.idnvbhNhanVienBHXH = new SelectList((from nv in db.nvbhNhanVienBHXH select new { id = nv.id, HoVaTen = nv.HoVaTen + " - " + nv.MANV }), "id", "HoVaTen");
            ViewBag.TyLeDong = new SelectList(from t in db.dmTyLeDongBHXH where t.TrangThai == true select t, "TongCong", "TongCong");
            ViewBag.idLoaiDieu = new SelectList(db.dmLoaiDieuChinh.AsEnumerable(), "id", "LoaiDieuChinh", nvbhdanhsachdieuchinhtanggiam.idLoaiDieuChinh);
            ViewBag.idLoaiTang = new SelectList(db.dmLoaiTangGiam, "Ma", "Ma", nvbhdanhsachdieuchinhtanggiam.idLoaiTangGiam);
     
            ViewBag.nvid = new SelectList(db.nvbhNhanVienBHXH, "NV_id", "HoVaTen", nvbhdanhsachdieuchinhtanggiam.NV_id);

            return PartialView(nvbhdanhsachdieuchinhtanggiam);
        }

        //
        // POST: /DanhSachDieuChinhTangGiam/Edit/5

        [HttpPost]
        public ActionResult Edit(nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    db.Entry(nvbhdanhsachdieuchinhtanggiam).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Message"] = "Sửa  thành công";
                    return RedirectToAction("Index2", "DanhSachDieuChinhTangGiam");

                }
            //}
            //catch { TempData["Message"] = "Sửa  không thành công"; }
            ViewBag.TyLeDong = new SelectList(from t in db.dmTyLeDongBHXH where t.TrangThai == true select t, "TongCong", "TongCong");
            ViewBag.idLoaiDieu = new SelectList(db.dmLoaiDieuChinh.AsEnumerable(), "id", "LoaiDieuChinh", nvbhdanhsachdieuchinhtanggiam.idLoaiDieuChinh);
            ViewBag.idLoaiTang = new SelectList(db.dmLoaiTangGiam, "Ma", "Ma", nvbhdanhsachdieuchinhtanggiam.idLoaiTangGiam);
            ViewBag.nvid = new SelectList(db.nvbhNhanVienBHXH, "NV_id", "HoVaTen", nvbhdanhsachdieuchinhtanggiam.NV_id);
            return View(nvbhdanhsachdieuchinhtanggiam);
           
        }



        public PartialViewResult QuaTrinhTatCa()
        {
            //nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
            ////if (nvbhdanhsachdieuchinhtanggiam == null)
            ////{
            ////    return HttpNotFound();
            ////}

            ViewBag.count = TempData["count"];
            //ViewBag.Manv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.MANV;
            //ViewBag.tennv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.HoVaTen;

            return PartialView();
        }

        //
        // POST: /Qua Trinh

        [HttpPost]
        public ActionResult QuaTrinhTatCa(nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam)
        {

            int maxId2 = (from c in db.nvbhDanhSachDieuChinhTangGiam select c.MoiNhat).Max();
            var TGBD = DateTime.ParseExact(TempData["startdate"].ToString(), "MM/dd/yyyy", CultureInfo.CurrentCulture);
            var TGKT = DateTime.ParseExact(TempData["enddate"].ToString(), "MM/dd/yyyy", CultureInfo.CurrentCulture);

            if (TGBD != null && TGKT != null)
            {
                var qtid = from qt in db.nvbhDanhSachDieuChinhTangGiam.ToArray() where TGBD <= qt.NgayPhatSinh && TGKT >= qt.NgayPhatSinh select qt.id;




                int i;
                for (i = 0; i < qtid.Count(); i++)
                {
                    nvbhDanhSachDieuChinhTangGiam hs = db.nvbhDanhSachDieuChinhTangGiam.Find(qtid.AsEnumerable().ElementAt(i));
                    hs.XacNhan = true;
                    hs.MoiNhat = maxId2;
                }
                db.SaveChanges();
                TempData["Message"] = "Đưa vào quá trình thành công";
            }
            return RedirectToAction("Index2");


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
        // GET: /DanhSachDieuChinhTangGiam/Delete/5

        public PartialViewResult Delete(int id = 0)
        {
            nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);

            ViewBag.hovaten = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.HoVaTen;
            ViewBag.manv = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.MANV;
            ViewBag.sobh = from nv in db.nvbhNhanVienBHXH where nv.NV_id == nvbhdanhsachdieuchinhtanggiam.NV_id select nv.SoBHXH;
            //if (nvbhdanhsachdieuchinhtanggiam == null)
            //{
            //    return HttpNotFound();
            //}
            return PartialView(nvbhdanhsachdieuchinhtanggiam);
        }

        //
        // POST: /DanhSachDieuChinhTangGiam/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(id);
                db.nvbhDanhSachDieuChinhTangGiam.Remove(nvbhdanhsachdieuchinhtanggiam);
                db.SaveChanges();
                TempData["Message"] = "Xóa thành công";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Xóa không thành công";
            }
            return RedirectToAction("Index2");
        }

        //coa hang loat
        public PartialViewResult xoahangloat(int id = 0)
        {
            
            
            return PartialView();
        }

        //
        // POST: /DanhSachDieuChinhTangGiam/Delete/5

        [HttpPost]
        public ActionResult xoahangloat()
        {
            try
            {
                nvbhDanhSachDieuChinhTangGiam nvbhdanhsachdieuchinhtanggiam = db.nvbhDanhSachDieuChinhTangGiam.Find(2);
                db.nvbhDanhSachDieuChinhTangGiam.Remove(nvbhdanhsachdieuchinhtanggiam);
                db.SaveChanges();
                TempData["Message"] = "Xóa thành công";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Xóa không thành công";
            }
            return RedirectToAction("Index2");
        }
  

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}