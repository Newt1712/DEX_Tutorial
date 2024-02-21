using System;

namespace AK.Core.UtilityModel
{
    public class UserInfoModel
    {
        public UserInfoModel() { }

        public UserInfoModel(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string? Avatar { get; set; }
    }
}
