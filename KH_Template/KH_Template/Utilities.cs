using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace KH_Template
{
    public class Utilities
    {
        public static string tab5 = "\t\t\t\t\t";
        public static Boolean isArabic(string text)
        {
            return Regex.IsMatch(text, @"\p{IsArabic}");
        }

        public static string AdjustDataBaseText(string text)
        {
            if (isArabic(text))
                return "N'" + text + "'";
            else
                return "'" + text + "'";
        }

        public static string GetCurrentUser()
        {
            return "KH";
        }
    }
}