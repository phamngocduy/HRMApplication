using System;
using System.Web.Mvc;
using System.Transactions;
using HRM.Webpages.Helpers;
namespace HRM.QLTinhLuong.Controllers
{
    public class QLHoSoHSLController : HoSoController
    {
        private string table = "nvQLHoSoHSL";

        public ActionResult Index()
        {
            return base.Index(0);
        }

        public PartialViewResult EditP(int? id)
        {
            ViewBag.db = db;
            return PartialView("Edit", id);
        }

        [HttpPost]
        public string UpdateS()
        {
            return base.UpdateS(table);
        }

        [HttpPost]
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }

        public PartialViewResult BaoLuuP(int HSL_id)
        {
            ViewBag.db = db;
            ViewBag.HSL_id = HSL_id;
            return PartialView("BaoLuu", HSL_id);
        }

        [HttpPost]
        public string BaoLuuS(int HSL_id)
        {
            using (var scope = new TransactionScope())
            {
                var str = db.SqlCreate("nvGiuBacLuong", Request.Form);
                if (str != null) return str;
                try
                {
                    db.SqlExecute("delete from nvQLHoSoHSL where HSL_id=" + HSL_id);
                }
                catch (Exception e)
                {
                    return e.Message;
                }
                scope.Complete();
            }
            return null;
        }

        [HttpPost]
        public ActionResult Upgrade(int[] HeSo_id, int[] HoSo_id)
        {
            using (var scope = new TransactionScope())
            {
                for (int i = 0; i < HeSo_id.Length; i++)
                {
                    if (HeSo_id[i] > 0)
                    {
                        db.SqlExecute(String.Format(@"
                update nvHeSoLuong set NgayKetThuc=DATEADD(d,-1,dsHeSoLuong.ThoiGianDenHan)
                from nvHeSoLuong inner join dsHeSoLuong on nvHeSoLuong.id=dsHeSoLuong.id
                where nvHeSoLuong.id = " + HeSo_id[i]));

                        db.SqlExecute(String.Format(@"
                insert into nvHeSoLuong(NV_id, NgayBatDau, ThoiGianGiuBac, NhomNgach_id, Ngach_id, BacLuong, HeSoLuong, PhuCap, LyDoThayDoi, User_id, GhiChu, SoQuyetDinh)
                select adHeSoLuong.NV_id, adHeSoLuong.NgayBatDau, adHeSoLuong.ThoiGianGiuBac, adHeSoLuong.NhomNgach_id, adHeSoLuong.Ngach_id, adHeSoLuong.BacLuong, adHeSoLuong.HeSoLuong, adHeSoLuong.PhuCap, @p0 as LyDoThayDoi, @p1 as User_id, @p2 as GhiChu, @p3 as SoQuyetDinh
                from adHeSoLuong where id =" + HoSo_id[i]),
                        Request.Form["LyDoThayDoi"], Request.Form["User_id"], Request.Form["GhiChu"], Request.Form["SoQuyetDinh"]);

                        db.SqlExecute(String.Format(@"
                update nvQLHoSoHSL set HoanThanh=1
                where id =" + HoSo_id[i]));
                    }
                }

                scope.Complete();
            }

            return RedirectToAction("Index");
//            using (var scope = new TransactionScope())
//            {
//                db.SqlExecute(String.Format(@"
//                update nvHeSoLuong set NgayKetThuc=DATEADD(d,-1,dsHeSoLuong.ThoiGianDenHan)
//                from nvHeSoLuong inner join dsHeSoLuong on nvHeSoLuong.id=dsHeSoLuong.id
//                where nvHeSoLuong.id in ({0})", String.Join(",", HeSo_id)));

//                db.SqlExecute(String.Format(@"
//                insert into nvHeSoLuong(NV_id, NgayBatDau, ThoiGianGiuBac, NhomNgach_id, Ngach_id, BacLuong, HeSoLuong, PhuCap, LyDoThayDoi, User_id, GhiChu, SoQuyetDinh)
//                select adHeSoLuong.NV_id, adHeSoLuong.NgayBatDau, adHeSoLuong.ThoiGianGiuBac, adHeSoLuong.NhomNgach_id, adHeSoLuong.Ngach_id, adHeSoLuong.BacLuong, adHeSoLuong.HeSoLuong, adHeSoLuong.PhuCap, @p0 as LyDoThayDoi, @p1 as User_id, @p2 as GhiChu, @p3 as SoQuyetDinh
//                from adHeSoLuong where id in ({0})", String.Join(",", HoSo_id)),
//                Request.Form["LyDoThayDoi"], Request.Form["User_id"], Request.Form["GhiChu"], Request.Form["SoQuyetDinh"]);

//                db.SqlExecute(String.Format(@"
//                update nvQLHoSoHSL set HoanThanh=1
//                where id in ({0})", String.Join(",", HoSo_id)));

//                scope.Complete();
//                return RedirectToAction("Index");
//            }
        }
    }
}
