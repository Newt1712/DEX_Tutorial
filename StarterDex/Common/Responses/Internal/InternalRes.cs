using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses.Internal
{
    public class InternalRes<T>
    {
        public InternalRes()
        {

        }

        public InternalRes(EnumApi.Response status, string message)
        {
            Status = status;
            Message = message;
        }

        public InternalRes(EnumApi.Response status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }

        public T Data { get; set; }
        public EnumApi.Response Status { get; set; }
        public string Message { get; set; }

    }
}
