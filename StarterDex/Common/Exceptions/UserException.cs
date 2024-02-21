using System;
using System.Collections.Generic;
using System.Text;
using AK.Common.Constants;

namespace AK.Common.Exceptions
{
    public class UserException : BaseException
    {
        public override string StatusCode { get; } = StatusCodeConst.USER_EXCEPTION;

        public UserException() : base($"{nameof(UserException)}.")
        {

        }

        public UserException(Exception exception) : base($"{nameof(UserException)}.", exception)
        {

        }
    }
}
