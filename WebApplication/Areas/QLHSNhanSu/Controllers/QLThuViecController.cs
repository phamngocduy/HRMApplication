using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
using System.Collections.Specialized;
namespace HRM.QLTTNhanSu.Controllers
{
    public class QLThuViecController : HoSoController
    {
        private string table = "nvQLThuViec";

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
        public string CreateS()
        {
            return base.CreateS(table);
        }

        [HttpPost]
        public string UpdateS()
        {
            var result = base.UpdateS(table);
            if (String.IsNullOrEmpty(result))
                if (!String.IsNullOrEmpty(Request.Form["MaNV"]))
                {
                    /*
                    result = base.CreateS("NhanVien");
                    if (!String.IsNullOrEmpty(result))
                    {
                        var form = new NameValueCollection(Request.Form);
                        form["MaNV"] = null;
                        db.SqlUpdate(table, form);
                    }
                    */
                    try
                    {
                        int id = int.Parse(Request.Form["id"]);
                        HRM.Services.QLTTNhanSu.taoNhanVienMoi_Ten(null, Request.Form["MaNV"], db.nvQLThuViec.Find(id).HoVaTen);
                    }
                    catch (Exception e)
                    {
                        var form = new NameValueCollection(Request.Form);
                        form["MaNV"] = null;
                        db.SqlUpdate(table, form);
                        result = e.Message;
                    }
                }
            return result;
        }

        [HttpPost]
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }

        public PartialViewResult EditNOP(int? id)
        {
            ViewBag.db = db;
            return PartialView("Edit_NO", id);
        }
        public PartialViewResult EditOKP(int? id)
        {
            ViewBag.db = db;
            return PartialView("Edit_OK", id);
        }
    }
}
