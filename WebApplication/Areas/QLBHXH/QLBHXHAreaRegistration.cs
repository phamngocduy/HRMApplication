using System.Web.Mvc;

namespace HRM.Webpages.Areas.QLBHXH
{
    public class QLBHXHAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLBHXH";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLBHXH_default",
                "QLBHXH/{controller}/{action}/{id}",
                new {controller = "QLBHXH" ,action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.QLBHXH.Controllers" }
            );
        }
    }
}
