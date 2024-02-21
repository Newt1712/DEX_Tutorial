using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Common.Exceptions
{
    public abstract class BaseException : Exception
    {
        public virtual string StatusCode { get; }

        protected BaseException(string message) : base(message)
        {
        }

        protected BaseException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
