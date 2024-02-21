using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class JwtEnum
    {
        public enum ValidateTokenStatus
        {
            SUCCESS,
            EXPIRED,
            FAILED
        }        
    }
}
