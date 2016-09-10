using System.Web.Mvc;

namespace HRM.QLDanhMuc
{
    public class QLDanhMucAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLDanhMuc";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLDanhMuc_default",
                "QLDanhMuc/{controller}/{action}/{dm}/{id}",
                new { controller = "DanhMuc", action = "List", dm = UrlParameter.Optional, id = UrlParameter.Optional },
                new string[] { "HRM.QLDanhMuc.Controllers" }
            );
        }
    }
}
