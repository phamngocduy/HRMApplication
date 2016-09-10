using System;
using System.Linq;
using System.Collections.Generic;
namespace HRM.Libraries.Helpers
{
    public static class LinqExtention
    {
        private static TSource Default<TSource>()
        {
            return Activator.CreateInstance<TSource>();
            /*value.GetType().GetProperties()
                    .Where(p => p.PropertyType.Equals(typeof(string)))
                    .Where(p => p.CanRead).Where(p => p.GetValue(value, null) == null)
                    .Where(p => p.CanWrite).ToList().ForEach(p => p.SetValue(value, "", null));*/
        }
        public static TSource FirstDefault<TSource>(this IEnumerable<TSource> source)
        {
            var value = source.FirstOrDefault();
            if (value == null) value = Default<TSource>();
            return value;
        }
        public static TSource FirstDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            var value = source.FirstOrDefault(predicate);
            if (value == null) value = Default<TSource>();
            return value;
        }
    }
}
