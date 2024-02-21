using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses
{
    public class ActivityResponseModel
    {
        public ActivityResponseModel() { }

        public ActivityResponseModel(int userId, string title, string description)
        {
            UserId = userId;
            Title = title;
            Description = description;
        }

        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
