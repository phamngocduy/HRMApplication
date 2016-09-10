using System.Web.Mvc;

namespace HRM.Webpages.Areas.TuyenDung
{
    public class TuyenDungAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TuyenDung";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TuyenDung_default",
                "TuyenDung/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.TuyenDung.Controllers" }
            );
        }
    }
}
