using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTinhLuong.Controllers
{
    public class HeSoLuongController : HoSoController
    {
        private string table = "nvHeSoLuong";

        public ActionResult Index()
        {
            return base.Index(0);
        }

        public ActionResult Details(int NV_id)
        {
            ViewBag.db = db;
            return View(NV_id);
        }

        public new PartialViewResult EditP(int? NV_id, int? id)
        {
            return base.EditP(NV_id, id);
        }

        [HttpPost]
        public string CreateS()
        {
            return base.CreateS(table);
        }

        [HttpPost]
        public string UpdateS()
        {
            return base.UpdateS(table);
        }

        [HttpPost]
        public string CurrentS(int HSL_id)
        {
            try
            {
                db.SqlExecute(String.Format(@"
                    update NhanVien set qltlHeSoLuong_id=nvHeSoLuong.id
                    from NhanVien inner join nvHeSoLuong on nvHeSoLuong.NV_id=NhanVien.id
                    where nvHeSoLuong.id={0}", HSL_id));
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }

        [HttpPost]
        public ActionResult Upgrade(int[] HSL_id)
        {
            db.SqlExecute(String.Format(@"
                insert into nvQLHoSoHSL(HSL_id, BacLuong, HeSoLuong, PhuCap, ThoiGianGiuBac)
                select * from adQLHoSoHSL where not exists (select * from nvQLHoSoHSL where nvQLHoSoHSL.HSL_id=adQLHoSoHSL.HSL_id)
                and HSL_id in ({0})", String.Join(",", HSL_id)));
            return RedirectToAction("Index", "QLHoSoHSL");
        }
    }
}