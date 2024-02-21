using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class CustomerEnum
    {
        public enum CustomerType
        {
            NONE = 0,
            INDIVIDUAL = 1,
            SHOP = 2,
            BUSINESS = 3,
            POOR_HOUSE = 4,
            GROUP_CHARITY = 5,
            NEAR_POOR_HOUSE = 6,
            GOVERNMENT = 7,
            ADMIN = 8
        }

        public enum GroupCharityType
        {
            WOMEN = 0,
            INDIVIDUAL = 1,
            SHOP = 2,
            BUSINESS = 3,
            POOR_HOUSE = 4,
            GROUP_CHARITY = 5,
            NEAR_POOR_HOUSE = 6,
            GOVERNMENT = 7,
            ADMIN = 8
        }


    }
}
