using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.UtilityModel
{
    public class PageListModel<T>
    {
        public List<T> List { get; set; }
        public int Total { get; set; }
    }
}
