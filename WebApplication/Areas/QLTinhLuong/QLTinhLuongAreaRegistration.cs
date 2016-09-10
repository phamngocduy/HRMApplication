using System.Web.Mvc;

namespace HRM.Webpages.Areas.QLTinhLuong
{
    public class QLTinhLuongAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLTinhLuong";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLTinhLuong_default",
                "QLTinhLuong/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.QLTinhLuong.Controllers" }
            );
        }
    }
}
