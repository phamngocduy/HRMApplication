using System.Web.Mvc;

namespace HRM.Webpages.Areas.QLVayMuon
{
    public class QLVayMuonAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "QLVayMuon";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "QLVayMuon_default",
                "QLVayMuon/{controller}/{action}/{id}",
                new {controller = "QLVayMuon" ,action = "Index", id = UrlParameter.Optional },
                new string[] { "HRM.QLVayMuon.Controllers" }
            );
        }
    }
}
