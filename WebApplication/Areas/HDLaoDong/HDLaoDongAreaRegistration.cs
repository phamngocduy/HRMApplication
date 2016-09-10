using System.Web.Mvc;

namespace HRM.Webpages.Areas.HDLaoDong
{
    public class HDLaoDongAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "HDLaoDong";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HDLaoDong_default",
                "HDLaoDong/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.HDLaoDong.Controllers" }
            );
        }
    }
}
