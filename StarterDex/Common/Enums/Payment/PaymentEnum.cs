using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class PaymentEnum
    {
        public enum PaymentMethod
        {
            PAYMENT_ON_DELIVERY = 1,
            FOXPAY = 4,
            CARDBANK = 5,
            INTERNATIONAL = 6
        }
        public enum PaymentStatus
        {
            CREATE = 1,
            COMPLETE = 2,
            CANCEL = 3,
            ERROR = 4
        }
    }
}
