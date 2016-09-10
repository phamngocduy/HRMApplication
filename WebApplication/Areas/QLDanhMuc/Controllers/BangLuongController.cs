using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class BangLuongController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int nhom = 0)
        {
            ViewBag.dmNhomNgach = new SelectList(db.dmNhomNgachVienChuc, "id", "tenNhomNgachVienChuc", nhom);
            return PartialView(db.dmBangLuong.Where(hs => hs.idNhomNgach == nhom).ToList());
        }

        public PartialViewResult Create(int nhom)
        {
            ViewBag.dmNhomNgach = db.dmNhomNgachVienChuc.Find(nhom);
            return PartialView();
        }

        [HttpPost]
        public string Create(dmBangLuong model)
        {
            if (ModelState.IsValid)
            {
                db.dmBangLuong.Add(model);
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            return PartialView(db.dmBangLuong.Find(id));
        }

        [HttpPost]
        public string Edit(dmBangLuong model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            db.dmBangLuong.Remove(db.dmBangLuong.Find(id));
            db.SaveChanges();
            return "OK";
        }

        public string maNgach(int idNgach)
        {
            return db.dmNgachVienChuc.Find(idNgach).maNgachVienChuc;
        }
        public int idNhomNgach(int idNgach)
        {
            return db.dmNgachVienChuc.Find(idNgach).nhomNgachVienChuc;
        }

        public string dsBacLuong(int idNhomNgach)
        {
            var nhomNgach = db.dmNhomNgachVienChuc.Find(idNhomNgach);
            return new JavaScriptSerializer().Serialize(
                db.dmBangLuong.Where(bl => bl.idNhomNgach == nhomNgach.id)
                  .OrderBy(dm => dm.bacLuong).AsEnumerable()
                  .Select(bl => new { key = bl.bacLuong, value = bl.bacLuong })
                );
        }

        public double HeSoLuong(int idNhomNgach, string bacLuong)
        {
            return db.dmBangLuong.Single(bl => bl.idNhomNgach == idNhomNgach && bl.bacLuong == bacLuong).hesoLuong;
        }
        public int PhuCap(int idNhomNgach, string bacLuong)
        {
            return db.dmBangLuong.Single(bl => bl.idNhomNgach == idNhomNgach && bl.bacLuong == bacLuong).phuCap;
        }
        public int SoThang(int idNhomNgach, string bacLuong)
        {
            return db.dmBangLuong.Single(bl => bl.idNhomNgach == idNhomNgach && bl.bacLuong == bacLuong).soThang;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}