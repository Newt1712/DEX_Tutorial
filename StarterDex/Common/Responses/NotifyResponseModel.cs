using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses
{
    public class NotifyResponseModel
    {
        public int[] Users { get; set; }
        public int TypeId { get; set; }
        public int ObjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
