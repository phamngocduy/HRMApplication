using System.Web.Mvc;

namespace HRM.QLDanhMuc
{
    public class TKBaoCaoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TKBaoCao";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TKBaoCao_default",
                "TKBaoCao/{controller}/{action}/{dm}/{id}",
                new { controller = "ThongKe", action = "Index", dm = UrlParameter.Optional, id = UrlParameter.Optional },
                new string[] { "HRM.TKBaoCao.Controllers" }
            );
        }
    }
}
