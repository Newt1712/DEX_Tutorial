using AK.Core.Enums;
using AK.Core.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Core.Requests.Approve
{
    public class ApproveReq
    {
        public string? Type { get; set; }
        public string? Status { get; set; }
        public int? ObjectId { get; set; }
        public string? Feedback { get; set; }
    }
}