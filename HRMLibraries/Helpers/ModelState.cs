using System;
using System.Linq;
using System.Web.Mvc;

namespace HRM.Webpages.Helpers
{
    public static class ModelStateExt
    {
        public static string getErrorMessage(this ModelStateDictionary ModelState)
        {
            foreach (var key in ModelState.Keys)
                foreach (var error in ModelState[key].Errors)
                    return error.ErrorMessage;
            return "ModelState Invalid!";
        }

        public static TSource FirstOrDefaultNull<TSource>(this IQueryable<TSource> source) where TSource : class
        {
            return source.FirstOrDefault() ?? Activator.CreateInstance<TSource>();
        }
    }
}