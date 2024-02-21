using System;
using AK.Core.Queries;

namespace AK.Core.UtilityModel
{
    public class GetListModel<T, E, Q>
        where Q : IQuery<T, E>, new()
    {
        public Action<Q> Query { get; set; }
        public string NameSort { get; set; }
        public bool? IsDesc { get; set; }
        public int? Skip { get; set; }
        public int? Top { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
