using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
using HRM.QLVayMuon.Models;
namespace HRM.QLVayMuon.Controllers
{
    public class NhanVienVayMuonController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /NhanVienVayMuon/

        public ActionResult Index()
        {
            //tra ra view danh sach nhanvienvaymuon
            return View(db.NhanVienVayMuon.ToList());
        }

        //
        // GET: /NhanVienVayMuon/Details/5

        public ActionResult Details(int NV_id = 0)
        {
            ViewBag.NV_id = NV_id;
            var chitietvay = from h in db.ChiTietVayMuon.OrderBy(x => x.idVm)
                             where h.IdNhanVienVayMuon == NV_id
                             select h;
            return View(chitietvay.ToList());
        }

        //
        // GET: /NhanVienVayMuon/Create
        //select HoVaTen,d.id as idDV, d.tenDonVi from nvSoYeuLyLich y, NhanVien n,nvQTCongTac q,dmDonVi d where y.NV_id=n.id and n.id=q.NV_id and q.DonVi_id=d.id
        public ActionResult Create(int id = 0)
        {
            //tao commbobox ten nv
            using (var nv= new HRM.Databases.Models.HRMDBEntities())
                ViewBag.ListItems = from y in nv.nvSoYeuLyLich
                          join n in nv.NhanVien on y.NV_id equals n.id
                                    join q in nv.nvQTLamViec on n.id equals q.NV_id
                          join d in nv.dmDonVi on q.DonVi_id equals d.id
                          where (q.ThoiGianKetThuc == null)
                          select new SelectListItem { Value = n.MaNV, Text = y.HoVaTen };
            
            return View();
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
                                 select new { value = n.MaNV + "-" + y.NV_id, key = y.HoVaTen }).Distinct());
        }




        [HttpPost]
        public ActionResult Create(NhanVienVayMuon nhanvienvaymuon)
        {   //kt null cac truong khi tao nv
            UpdateModel(ModelState, nhanvienvaymuon);
            try
            {
                if (ModelState.IsValid)
                {   //them nv vao bang nhanvienvaymuon
                    db.NhanVienVayMuon.Add(nhanvienvaymuon);
                    db.SaveChanges();
                    TempData["Message"] = "Thêm mới nhân viên vay mượn thành công";
                    //chuyen huong ve trang index cua nhanvienvaymuon
                    return RedirectToAction("index");
                }
            }
            catch (Exception e)
            {
                TempData["Message"] = "Thêm mới nhân viên vay mượn không thành công";
            }
            return View(nhanvienvaymuon);


        }



        //kiem tra ton tai manv
        public static void UpdateModel(ModelStateDictionary ModelState, NhanVienVayMuon nhanvienvaymuon)
        {
            if (ModelState.IsValid)
            {
                nhanvienvaymuon.MaNV = nhanvienvaymuon.MaNV.Trim();
                nhanvienvaymuon.DonVi_id = nhanvienvaymuon.DonVi_id;
                using (var db = new HRMDB1Entities())
                {
                    //neu trong db da ton tai nhanvien vua moi chon thi thong bao
                    if (db.NhanVienVayMuon.FirstOrDefault(nv => (nv.MaNV == nhanvienvaymuon.MaNV)) != null && db.NhanVienVayMuon.FirstOrDefault(nv => (nv.DonVi_id == nhanvienvaymuon.DonVi_id)) != null)
                        ModelState.AddModelError("MaNV", "Nhân viên này đã tồn tại trong danh sách nhân viên vay mượn");
                }

            }

        }


        //tao ra view de load bao cao
        public ActionResult Baocao()
        {
            return View();
        }



        //
        // GET: /NhanVienVayMuon/Edit/5

        public ActionResult Edit(int id = 0)
        {   //tim nv co id=id
            NhanVienVayMuon nhanvienvaymuon = db.NhanVienVayMuon.Find(id);
            //nv khong ton tai
            if (nhanvienvaymuon == null)
            {
                return HttpNotFound();
            }
            //tra thong tin nv ra view
            return View(nhanvienvaymuon);
        }

        //
        // POST: /NhanVienVayMuon/Edit/5

        [HttpPost]
        public ActionResult Edit(NhanVienVayMuon nhanvienvaymuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvienvaymuon).State = EntityState.Modified;
                //luu xong bang nhanvienvaymuon
                db.SaveChanges();
                //chuyen huong ve index cua nhanvienvaymuon
                return RedirectToAction("Index");
            }
            return View(nhanvienvaymuon);
        }

        //
        // GET: /NhanVienVayMuon/Delete/5

        public ActionResult Delete(int NV_id = 0)
        {
            //tim nhanvien co id=NV_id
            NhanVienVayMuon nhanvienvaymuon = db.NhanVienVayMuon.Find(NV_id);
            //khong co nhv
            if (nhanvienvaymuon == null)
            {
                return HttpNotFound();
            }
            return View(nhanvienvaymuon);
        }

        //
        // POST: /NhanVienVayMuon/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int NV_id)
        {
            try
            {
                //tin nv co id=nv_id
                NhanVienVayMuon nhanvienvaymuon = db.NhanVienVayMuon.Find(NV_id);
                //hoa nv 
                db.NhanVienVayMuon.Remove(nhanvienvaymuon);
                db.SaveChanges();
                //thong bao
                TempData["Message"] = "Xóa nhân viên vay mượn thành công";
            }
            catch (Exception e)
            {
                //thong bao
                TempData["Message"] = "Xóa nhân viên vay mượn không thành công";
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}