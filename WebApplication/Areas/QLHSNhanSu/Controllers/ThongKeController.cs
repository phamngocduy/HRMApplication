using System;
using System.IO;
using System.Web.Mvc;

using HRM.Services;
using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Controllers
{
    public class ThongKeController : Controller
    {
        HRMDBEntities db = new HRMDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bieu51()
        {
            return View(db);
        }

        public ActionResult Bieu52()
        {
            return View(db);
        }

        public ActionResult BaoCao3CongKhai(int F_id, bool save = false)
        {
            BaoCao(F_id, save);
            return View();
        }

        public ActionResult BaoCaoNganhGiangDay(int F_id, bool save = false)
        {
            BaoCao(F_id, save);
            return View();
        }

        private void BaoCao(int F_id, bool save)
        {
            ViewBag.Save = save;
            var TaiNguyen = db.TaiNguyen.Find(F_id);
            ViewBag.File = TaiNguyen.tepDinhKem;
            ViewBag.Path = QLDanhMuc.getDuongDanTapTin(Server, db, F_id);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}
