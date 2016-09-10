using System.Web.Mvc;

namespace HRM.QLThinhGiang
{
    public class QLThinhGiangAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLThinhGiang";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLThinhGiang_default",
                "QLThinhGiang/{controller}/{action}/{id}",
                new { controller = "HSNhanSu", action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.QLThinhGiang.Controllers" }
            );
        }
    }
}
