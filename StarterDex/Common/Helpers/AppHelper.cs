using AK.Common.Constants;
using System.Text;

namespace AK.Common.Helpers
{
    public static class AppHelper
    {
        // public static string PagingHelper(this HtmlHelper helper, string url, PagingInfo page)
        public static string PagingHelper(string url , PagingInfo page)
        {
            // if more than 1 page
            var html = new StringBuilder();

            if (page.TotalPages <= 1)
            {
                html.Append(string.Format("<div class='fs-6 fw-semibold text-gray-700'>Showing {0} entries</div>",
                page.TotalRecords));
                return html.ToString(); 
            }

            html.Append(string.Format("<div class='fs-6 fw-semibold text-gray-700'>Showing {0} to {1} of {2} entries</div>",
               (page.CurrentPage * page.PageSize), ((page.CurrentPage * page.PageSize) + page.PageSize), page.TotalRecords));

            var search = url + "?page={0}";
			if (page.PageSize > 0)
				search += "&pageSize=" + page.PageSize;
			if (!String.IsNullOrEmpty(page.Name))
                search += "&name=" + page.Name.Trim();
            if (page.CountryId > 0)
                search += "&countryid=" + page.CountryId;
            if (page.StateId > 0)
                search += "&stateid=" + page.StateId;

            search += string.Format("&orderby={0}&direction={1}", page.OrderBy, page.Direction);
            search = search.ToLower();

            html.Append("<ul class='pagination'>");

            html.Append(String.Format("<li class='page-item previous " + (page.CurrentPage == 1 ? "disabled" : "") + "'><div class='page-link' data-route='"
                    + search + "'><i class='previous'></i></div></li>", (page.CurrentPage == 1 ? 1 : page.CurrentPage - 1)));

            #region[Show all the pages]
            if (page.TotalPages <= 5)
            {
                html.Append(String.Format("<li class='page-item " + (page.CurrentPage == 1 ? "disabled active" : "") + "'><div class='page-link' data-route='"
					+ search + "'>1</div></li>", 1));
                html.Append(String.Format("<li class='page-item " + (page.CurrentPage == 2 ? "disabled active" : "") + "'><div class='page-link' data-route='"
					+ search + "'>2</div></li>", 2));

                if (page.TotalPages >= 3)
                    html.Append(String.Format("<li class='page-item " + (page.CurrentPage == 3 ? "disabled active" : "") + "'><a class='page-link' data-route='"
                        + search + "'>3</a></li>", 3));

                if (page.TotalPages >= 4)
                    html.Append(String.Format("<li class='page-item " + (page.CurrentPage == 4 ? "disabled active" : "") + "'><a class='page-link' data-route='"
                        + search + "'>4</a></li>", 4));

                if (page.TotalPages >= 5)
                    html.Append(String.Format("<li class='page-item " + (page.CurrentPage == 5 ? "disabled active" : "") + "'><a class='page-link' data-route='"
                        + search + "'>5</a></li>", 5));
            }
            #endregion

            else if (page.TotalPages > 5)
            {
                if (page.CurrentPage < 5)
                {
                    for (var i = 1; i <= page.TotalPages; i++)
                    {
                        html.Append(String.Format("<li class='page-item " + (page.CurrentPage == i ? "disabled active" : "")
                            + "'><div class='page-link' data-route='" + search + "'>{0}</div></li>", i));
                        if (i == 5) break;
                    }

                    // Last Page with  ..
                    html.Append("<li class='page-item disabled'><a class='page-link' data-route='#'>...</a></li>");
                    html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.TotalPages));
                }
                else
                {
                    html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", 1));
                    html.Append("<li class='page-item disabled'><div class='page-link' data-route='#'>...</div></li>");
                    if (page.CurrentPage == page.TotalPages)
                    {
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage - 4));
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage - 3));
                    }
                    else if (page.CurrentPage + 1 == page.TotalPages)
                    {
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage - 3));
                    }

                    html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage - 2));
                    html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage - 1));
                    html.Append(String.Format("<li class='page-item disabled active'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage));

                    if (page.CurrentPage + 1 <= page.TotalPages)
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage + 1));

                    if (page.CurrentPage + 2 <= page.TotalPages)
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.CurrentPage + 2));

                    // still more pages
                    if (page.CurrentPage + 2 < page.TotalPages)
                    {
                        html.Append("<li class='page-item disabled'><div class='page-link' data-route='#'>...</div></li>");
                        html.Append(String.Format("<li class='page-item'><div class='page-link' data-route='" + search + "'>{0}</div></li>", page.TotalPages));
                    }
                }
            }
            html.Append(String.Format("<li class='page-item next" + (page.CurrentPage == page.TotalPages ? "disabled" : "") + "'><div class='page-link' data-route='"
                    + search + "'><i class='next'></i></div></li>", (page.CurrentPage == page.TotalPages ? page.TotalPages : page.CurrentPage + 1)));
            html.Append("</ul>");

            return html.ToString();
        }
    }
}