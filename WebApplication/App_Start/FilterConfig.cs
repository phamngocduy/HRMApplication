using System.Web;
using System.Web.Mvc;

using HRM.Webpages.Filters;
using HRM.Accounts.Filters;
namespace HRM.Webpages
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogAttribute());
            filters.Add(new ErrorAttribute());
            filters.Add(new AuthorizeFilter());
            filters.Add(new ValidateInputAttribute(false));
        }
    }
}