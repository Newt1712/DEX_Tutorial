using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AK.Common.Extensions
{
    public static class NumberExtension
    {
        public static string ConvertNumber(this string number)
        {
            var result = "0";
            try
            {
                if (!string.IsNullOrEmpty(number))
                {
                    result = ConvertNumber(Int32.Parse(number));
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        public static string ConvertNumber(this int number)
        {
            var result = "0";

            try
            {
                if (number != 0)
                {
                    result = number.ToString("#,#");
                    if (result.Contains(","))
                        result = result.Replace(',', '.');
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        public static string ConvertNumber(this int? number)
        {
            var result = "0";
            try
            {
                if (number.HasValue && number != 0)
                {
                    result = number.Value.ToString("#,#");
                    if (result.Contains(","))
                        result = result.Replace(',', '.');
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        public static string ConvertNumber(this decimal? number)
        {
            var result = "0";
            try
            {
                if (number.HasValue && number != 0)
                {
                    result = number.Value.ToString("#,#");
                    if (result.Contains(","))
                        result = result.Replace(',', '.');
                }
            }
            catch (Exception)
            {
            }

            return result;
        }
        public static string FormatCurrency(this decimal? amount)
        {
            if (!amount.HasValue) return string.Empty;

            string formattedAmount = amount.Value.ToString("#,##0") + " đ";
            return formattedAmount.Replace(",", ".");
        }

        public static string ToFormatNumber(this long? number)
        {
            if(!number.HasValue) return string.Empty;

            if (number < 1000)
            {
                return number.ToString()!;
            }
            else if (number < 1000000)
            {
                return $"{number / 1000}K";
            }
            else if (number < 1000000000)
            {
                return $"{number / 1000000}M";
            }
            else
            {
                return $"{number / 1000000000}B";
            }
        }
        public static string FormatPrice(this decimal? price)
        {
            if (price.HasValue && price != 0)
            {
                if (price >= 1)
                {
                    var textA = price / 1000000;
                    if (textA >= 1)
                    {
                        var textB = price / 1000000000;
                        if (textB >= 1)
                            return textB + "B";
                        return textA + "M";
                    }
                    return price + "VNĐ";
                }
            }
            return "0 VNĐ";
        }

        public static string ToFormatNumber(this int? number)
        {
            return ((long?)number).ToFormatNumber();
        }

        public static string ToFormatNumber(this int number)
        {
            return ((long?)number).ToFormatNumber();
        }
        public static string ToFormatNumber(this decimal? number)
        {
            return ((long?)number).ToFormatNumber();
        }
    }
}
