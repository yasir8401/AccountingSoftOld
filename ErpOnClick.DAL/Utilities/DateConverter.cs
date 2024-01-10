using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public class DateConverter
    {
        public static string covertToHijri(string date)
        {
            if (date != null) {
            var d = DateTime.Parse(date);
            var dateProperFormat = d.ToString("dd-MMM-yyyy");
            CultureInfo CI = new CultureInfo("en-US");
            DateTime dt = DateTime.ParseExact(dateProperFormat, "dd-MMM-yyyy", CI.DateTimeFormat, DateTimeStyles.AllowInnerWhite);

            CultureInfo arSA = CultureInfo.CreateSpecificCulture("ar-SA");
                 
            return dt.ToString("dd-M-yyyy", arSA);
            }
            else
            {
                return "";
            }

        }

        
        public static string covertToGregorian(string date)
        {
            //var d = DateTime.Parse(date);
            //var dateProperFormat = d.ToString("dd-MMM-yyyy");
            if (date != null)
            {

                CultureInfo CI = new CultureInfo("ar-SA");
                DateTime tempDate = DateTime.ParseExact(date, "dd-M-yyyy", CI.DateTimeFormat, DateTimeStyles.AllowInnerWhite);
                return tempDate.ToString("dd-MMM-yyyy");
            }
            else
            {
                return "";
            }
        }
    }
}
