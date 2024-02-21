using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AK.Common.Extensions
{
    public static class ListExtension
    {
        public static string GetHtmlTable<T>(this IEnumerable<T> list, params Func<T, object>[] columns)
        {
            var sb = new StringBuilder();
            sb.Append("<TABLE>\n");
            foreach (var item in list)
            {
                sb.Append("<TR>\n");
                foreach (var fxn in columns)
                {
                    sb.Append("<TD>");
                    sb.Append(fxn(item));
                    sb.Append("</TD>");
                }
                sb.Append("</TR>\n");
            }
            sb.Append("</TABLE>");

            return sb.ToString();
        }
    }
}
