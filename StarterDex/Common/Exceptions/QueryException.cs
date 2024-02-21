using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Common.Exceptions
{
    public class QueryException : BaseException
    {
        public override string StatusCode { get; } = "QUERY_ERROR";

        public QueryException() : base($"Query wrong.")
        {
            
        }

        public QueryException(Exception exception) : base($"Query wrong.", exception)
        {

        }
    }
}
