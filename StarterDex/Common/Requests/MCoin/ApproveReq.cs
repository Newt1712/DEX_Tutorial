using AK.Core.Enums;
using AK.Core.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Core.Requests.MCoin
{
    public class ResetCoinInReq
    {
        public int? UserId { get; set; }
    }
}