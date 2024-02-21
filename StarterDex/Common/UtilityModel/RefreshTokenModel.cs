using System;

namespace AK.Core.UtilityModel
{
    public class RefreshTokenModel
    {
        public RefreshTokenModel() { }

        public RefreshTokenModel(int? userId, string jwtToken, DateTime? expired) 
        {
            UserId = userId;
            JwtToken = jwtToken;
            DateExpired = expired;
        }

        public int? UserId { get; set; }
        public string JwtToken { get; set; }
        public DateTime? DateExpired { get; set; }
    }
}
