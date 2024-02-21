using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AK.Common.Extensions
{
    public static class JsonExtension
    {
        public static bool IsNullOrEmpty(this JToken token)
        {
            return (token == null) ||
                   (token.Type == JTokenType.Array && !token.HasValues) ||
                   (token.Type == JTokenType.Object && !token.HasValues) ||
                   (token.Type == JTokenType.String && token.ToString() == string.Empty) ||
                   (token.Type == JTokenType.Null);
        }

        public static int[]? ToArrayInt(this JToken token)
        {
            try
            {
                return ToArrayIntNul(token)?.Where(c => c.HasValue).Select(c => c!.Value).ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int?[]? ToArrayIntNul(this JToken token)
        {
            try
            {
                if (token != null && token.Type == JTokenType.Array && token.HasValues)
                    return token.ToObject<int?[]?>();
            }
            catch (Exception)
            {
            }

            try
            {
                if (token != null && token.Type == JTokenType.String && !string.IsNullOrEmpty(token.ToString()))
                    return $"{token}".Split(',').Select(c => (int?)int.Parse(c)).ToArray();
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
