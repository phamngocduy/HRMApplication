using System.Web.Mvc;

namespace HRM.QLTTNhanSu
{
    public class QLHSNhanSuAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLHSNhanSu";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLHSNhanSu_default",
                "QLTTNhanSu/{controller}/{action}/{id}",
                new { controller = "HSNhanSu", action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.QLTTNhanSu.Controllers" }
            );
        }
    }
}
