using System;
using System.Web.Mvc;
using System.Collections.Specialized;

using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class SoYeuLyLichController : HoSoController
    {
        private string table = "nvSoYeuLyLich";

        public new PartialViewResult EditP(int? NV_id, int? id)
        {
            return base.EditP(NV_id, id);
        }

        [HttpPost]
        public ActionResult Update(bool ChonNoiSinhKhac, bool ChonQueQuanKhac)
        {
            var form = new NameValueCollection();
            form.Add("id", Request.Form["id"]);
            form.Add("MaHS", Request.Form["MaHS"]);
            form.Add("MaNV", Request.Form["MaNV"]);
            form.Add("MaST", Request.Form["MaST"]);
            form.Add("ngayNghiViec", Request.Form["ngayNghiViec"]);
            form.Add("qtlvSoQDNghiViec", Request.Form["qtlvSoQDNghiViec"]);
            db.SqlUpdate("NhanVien", Request.Form);

            form = new NameValueCollection(Request.Form);
            form.Remove("id");
            form.Add("id", Request.Form["nid"]);
            if (!ChonNoiSinhKhac) form["NoiSinhKhac"] = null;
            if (!ChonQueQuanKhac) form["QueQuanKhac"] = null;
            db.SqlUpdate(table, form);
            return Redirect(Request.UrlReferrer.AbsoluteUri);
        }
    }
}