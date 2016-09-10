using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.TKBaoCao.Controllers
{
    public class NganhGiangDayController : HoSoController
    {
        public ActionResult List()
        {
            ViewBag.db = db;
            return View();
        }

        private string table = "nvNganhGiangDay";

        public new ActionResult Index(int NV_id)
        {
            return base.Index(NV_id);
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
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }

        [HttpPost]
        public string CurrentS(int id)
        {
            try
            {
                db.SqlExecute(String.Format(@"
                    update NhanVien set nvNganhGiangDay_id=nvNganhGiangDay.id
                    from NhanVien inner join nvNganhGiangDay on nvNganhGiangDay.NV_id=NhanVien.id
                    where nvNganhGiangDay.id={0}", id));
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }

        [HttpPost]
        public string ReportS(int id, DateTime ngayBC)
        {
            try
            {
                var khoa = db.nvNganhGiangDay.Find(id);
                var chinh = db.bcKhoaGiangDay.SingleOrDefault(k => k.NV_id == khoa.NV_id && k.NgayBC.Equals(ngayBC));
                if (chinh != null)
                {
                    chinh.Chinh_id = id;
                    db.Entry(chinh).State = EntityState.Modified;
                }
                else
                {
                    db.bcKhoaGiangDay.Add(new bcKhoaGiangDay
                    {
                        NV_id = khoa.NV_id, Chinh_id = id, NgayBC = ngayBC
                    });
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }
    }
}
