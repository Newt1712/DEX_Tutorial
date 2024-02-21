using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses
{
    public class ApiExtendResponseModel<T>
    {
        public ApiResponseModel<T> ApiResponse { get; set; }
        public ActivityResponseModel Activity { get; set; }
        public NotifyResponseModel Notify { get; set; }

    }
}
