using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public static class Udf
    {
        public static string getLang()
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            string lang = cultureInfo.Name.ToLower().Trim();
            return lang;
        }

        public static bool isArabic()
        {
            string lang = getLang();
            return lang == "ar";
        }

    }
}
