using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Core.Requests.User
{
    public class LoginReq
    {
        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("captcha")]
        public string? Captcha { get; set; }
    }
}