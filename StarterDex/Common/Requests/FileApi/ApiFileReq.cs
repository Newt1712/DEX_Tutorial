using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AK.Core.Requests.FileApi
{
    public class ApiFileReq<T>
    {
        public ApiFileReq()
        {
            DateStartRequest = DateTime.Now;
            IsRequestSucess = false;
            Number = 1;
        }

        public ApiFileReq(string url)
        {
            DateStartRequest = DateTime.Now;
            IsRequestSucess = false;
            Number = 1;
            UrlApi = url;
        }

        public ApiFileReq(string url, object data)
        {
            DateStartRequest = DateTime.Now;
            IsRequestSucess = false;
            Number = 1;
            UrlApi = url;
            Data = data;
        }

        public int TracingCode { get; set; }
        public string UrlApi { get; set; }
        public object Data { get; set; }
        public string Response { get; set; }
        public T ResponseData
        {
            get
            {
                try
                {
                    if(IsRequestSucess && !string.IsNullOrEmpty(Response)) 
                        return JObject.Parse(Response).ToObject<T>();
                }
                catch (Exception)
                {
                }

                return default;
            }
        }
        public int Number { get; set; }
        public bool IsRequestSucess { get; set; }
        public int HttpCode { get; set; }
        public DateTime DateStartRequest { get; set; }
        public DateTime DateEndRequest { get; set; }
        public int SecondExecute { get; set; }
        public Exception Excetion { get; set; }
    }
}
