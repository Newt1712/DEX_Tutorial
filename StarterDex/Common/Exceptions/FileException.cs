using System;
using System.Collections.Generic;
using System.Text;
using AK.Common.Constants;

namespace AK.Common.Exceptions
{
    public class FileException : BaseException
    {
        public override string StatusCode { get; } = StatusCodeConst.FILE_EXCEPTION;

        public FileException() : base($"{nameof(FileException)}")
        {
            
        }

        public FileException(Exception exception) : base($"{nameof(FileException)}", exception)
        {

        }
    }
}
