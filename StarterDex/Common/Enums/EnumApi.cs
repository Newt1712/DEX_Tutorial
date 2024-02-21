using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class EnumApi
    {
        public enum Response
        {
            ZERO = 0,
            ONE = 1,
            TWO = 2,
            THREE = 3,
            FOUR = 4,
            FIVE = 5
        }

        public enum LocationType
        {
            PROVINCE = 1,
            DISTRICT = 2,
            COMMUNE = 3
        }

        public enum NotifyTypeCode
        {
            NEWS_FEED,
            COMMENT,
            MCOIN,
            LAUDATORY,
            REPRIMAND,
            SURVEY,
            TICKET,
            HISTAFF,
        }

        public enum ArticleType
        {
            NEWS = 1,
            GUIDE = 2,
            FAQ = 3,
            NEWS_MAVIN = 4,
            COMMUNITY = 12
        }
    }
}
