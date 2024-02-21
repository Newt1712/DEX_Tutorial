using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses
{
    public class ApiResponseModel<T>
    {
        public ApiResponseModel()
        {

        }

        public ApiResponseModel(EnumApi.Response status, string message)
        {
            StatusCode = status;
            Message = message;
        }

        public ApiResponseModel(EnumApi.Response status, string message, T data)
        {
            StatusCode = status;
            Message = message;
            Data = data;
        }

        public T Data { get; set; }
        public EnumApi.Response StatusCode { get; set; }
        public string Message { get; set; }

    }
}
