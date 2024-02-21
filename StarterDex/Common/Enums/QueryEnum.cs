using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class QueryEnum
    {
        public enum QueryCondition
        {
            CONTAINS = 1,
            ARRAY_INDEX = 2,
            EQUAL = 3,
            NOT_EQUAL = 4,
            GREATER_THAN_OR_EQUAL = 5,
            LESS_THAN_OR_EQUAL = 6
        }

        public enum QueryMethod
        {
            ANY = 1,
            COUNT = 2,
            SUM = 3
        }
    }
}
