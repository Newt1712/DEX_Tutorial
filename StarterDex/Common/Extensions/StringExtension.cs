using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AK.Common.Extensions
{
    public static class StringExtension
    {
        public static string ToAsciiNoSeparator(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            str = str.ToLower().Trim();
            str = Regex.Replace(str, "[á|à|ả|ã|ạ|â|ă|ấ|ầ|ẩ|ẫ|ậ|ắ|ằ|ẳ|ẵ|ặ]", "a", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ]", "e", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự]", "u", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[í|ì|ỉ|ĩ|ị]", "i", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ó|ò|ỏ|õ|ọ|ô|ơ|ố|ồ|ổ|ỗ|ộ|ớ|ờ|ở|ỡ|ợ]", "o", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[đ|Đ]", "d", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ý|ỳ|ỷ|ỹ|ỵ|Ý|Ỳ|Ỷ|Ỹ|Ỵ]", "y", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[,|~|@|/|.|:|?|#|$|%|&|*|(|)|+|”|“|'|\"|!|`|–]", "", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, @"\s+", " ");

            return str;
        }

        public static string ToAscii(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            str = str.ToLower().Trim();
            str = Regex.Replace(str, "[á|à|ả|ã|ạ|â|ă|ấ|ầ|ẩ|ẫ|ậ|ắ|ằ|ẳ|ẵ|ặ]", "a", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ]", "e", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự]", "u", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[í|ì|ỉ|ĩ|ị]", "i", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ó|ò|ỏ|õ|ọ|ô|ơ|ố|ồ|ổ|ỗ|ộ|ớ|ờ|ở|ỡ|ợ]", "o", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[đ|Đ]", "d", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[ý|ỳ|ỷ|ỹ|ỵ|Ý|Ỳ|Ỷ|Ỹ|Ỵ]", "y", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, "[,|~|@|/|.|:|?|#|$|%|&|*|(|)|+|”|“|'|\"|!|`|–]", "", RegexOptions.IgnoreCase);
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Replace(str, "[\\s]", "-");
            str = Regex.Replace(str, @"-+", "-");

            return str;
        }

        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(this string base64EncodedData)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64EncodedData.Replace('-', '+').Replace('_', '/').PadRight(4 * ((base64EncodedData.Length + 3) / 4), '='))); ;
        }

        public static List<string> GetHashtag(this string text)
        {
            List<string> lst = new List<string>();
            string[] arr = text.Split(' ');
            MatchCollection mc = Regex.Matches(text, @"[#]\S+\b");
            foreach (Match m in mc)
            {
                var appear = Appear(m.ToString(), "#");
                if (appear > 1)
                {
                    string[] arrr = m.ToString().Split('#');
                    if (arrr.Count() != 0)
                        foreach (var item in arrr)
                            if (!string.IsNullOrEmpty(item))
                                lst.Add($"#{item}");
                }
                else
                    lst.Add(m.Value);
            }
            return lst.ToList();
        }

        private static int Appear(string text, string key)
        {
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            while (strt != -1)
            {
                strt = text.IndexOf(key, idx + 1);
                cnt += 1;
                idx = strt;
            }
            return cnt;
        }

        public static string RemoveHtml(this string source)
        {
            if (string.IsNullOrEmpty(source) == false)
            {
                return Regex.Replace(source, "<.*?>", "");
            }
            return string.Empty;
        }

        public static (string, int) CompareTimeToString(this DateTime date1, DateTime date2)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = (date1 - date2);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 2 * SECOND)
                return ("vừa xong", 0);

            if (delta < 1 * MINUTE)
                return ("{0} giây trước", ts.Seconds);

            if (delta < 2 * MINUTE)
                return ("{0} phút trước", 1);

            if (delta < 45 * MINUTE)
                return ("{0} phút trước", ts.Minutes);

            if (delta < 90 * MINUTE)
                return ("{0} giờ trước", 1);

            if (delta < 24 * HOUR)
                return ("{0} giờ trước", ts.Hours);

            if (delta < 48 * HOUR)
                return ("{0} ngày trước", 1);

            if (delta < 30 * DAY)
                return ("{0} ngày trước", ts.Days);

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ?
                    ("{0} tháng trước", 1) : ("{0} tháng trước", months);
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ?
                    ("{0} năm trước", 1) : ("{0} năm trước", years);
            }

        }

        public static (string, int) CompareTimeToString_Old(this DateTime date1, DateTime date2)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = (date1 - date2);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 2 * SECOND)
                return ("JUST_DONE", 0);

            if (delta < 1 * MINUTE)
                return ("SECONDS_AGO", ts.Seconds);

            if (delta < 2 * MINUTE)
                return ("MINUTE_AGO", 1);

            if (delta < 45 * MINUTE)
                return ("MINUTE_AGO", ts.Minutes);

            if (delta < 90 * MINUTE)
                return ("HOUR_AGO", 1);

            if (delta < 24 * HOUR)
                return ("HOUR_AGO", ts.Hours);

            if (delta < 48 * HOUR)
                return ("DAY_AGO", 1);

            if (delta < 30 * DAY)
                return ("DAY_AGO", ts.Days);

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ?
                    ("MONTH_AGO", 1) : ("MONTH_AGO", months);
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ?
                    ("YEAR_AGO", 1) : ("MONTH_AGO", years);
            }

        }

        public static (string, string) ShortCut(this string text)
        {
            try
            {
                var htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);
                var textRemoveHtml = htmlRegex.Replace(text, string.Empty);

                int strt = 0;
                int index = 0;
                int cnt = -1;
                int idx = -1;
                string str = "";
                string? strData = "";

                while (strt != -1)
                {
                    strt = text.IndexOf("<br />", idx + 1);
                    cnt += 1;
                    idx = strt;
                    if (cnt == 5)
                        index = strt;
                }

                if (cnt <= 5 && textRemoveHtml.Length <= 100)
                    return (string.Empty, text);

                if (cnt > 5)
                    return ("FILL_STRING_COMMUNITY", text.Substring(0, index));
                if (textRemoveHtml.Length > 100)
                {
                    var arrText = textRemoveHtml.Split(" ");
                    for (int i = 0; i < arrText.Count(); i++)
                    {
                        var item = $"{arrText[i]}" + " ";
                        var indexText = text.IndexOf(item);
                        str += $"{item}";
                        if (str.Length >= 90 && indexText != -1)
                        {
                            strt = 0;
                            index = 0;
                            cnt = -1;
                            idx = -1;
                            while (strt != -1)
                            {
                                strt = text.IndexOf($"{item}", idx + 1);
                                cnt += 1;
                                idx = strt;
                                strData = text.Substring(0, strt);
                                if (strData.Length >= 90)
                                    return ("FILL_STRING_COMMUNITY", strData);
                            }
                            return (string.Empty, text);
                        }

                    }
                    return (string.Empty, text);
                }
            }
            catch (Exception ex)
            {
            }
            return (string.Empty, text);
        }

        public static string MiddleName(this string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                return string.Empty;
            }

            // Tách họ và tên
            string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Lấy hai ký tự đầu tiên từ họ và tên (nếu có)
            string initials = "";
            if (nameParts.Length > 0)
            {
                initials += nameParts[0].Length > 0 ? nameParts[0][0].ToString().ToUpper() : "";
            }
            if (nameParts.Length > 1)
            {
                initials += nameParts[1].Length > 0 ? nameParts[1][0].ToString().ToUpper() : "";
            }

            return initials;
        }
        public static string ColorNameSort(this string name)
        {
            // Tách họ và tên
            string[] color = { "primary", "secondary","success", "danger", "warning", "info", "dark"};

            Random random = new Random();
            int index = random.Next(color.Length);
            return color[index];
        }

        public static string ConvertSize(this decimal? sizeInBytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            int suffixIndex = 0;
            while (sizeInBytes >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                sizeInBytes /= 1024;
                suffixIndex++;
            }

            return $"{sizeInBytes:n1} {suffixes[suffixIndex]}";
        }

        public static string ConvertSize(this string sizeInBytes)
        {
            var result = "0";

            try
            {
                if (!string.IsNullOrEmpty(sizeInBytes))
                {
                    result = ConvertSize(Decimal.Parse(sizeInBytes));
                }
            }
            catch (Exception)
            {
            }

            return result;
        }
    }


}