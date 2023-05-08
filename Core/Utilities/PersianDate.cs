using System.Globalization;

namespace Core.Utilities
{
    public static class PersianDate
    {

        public static string ToGregorian(this DateTime date)
        {
            GregorianCalendar en = new GregorianCalendar();
            return string.Format("{0}/{1}/{2}", en.GetYear(date).ToString(), en.GetMonth(date).ToString("00"),
                en.GetDayOfMonth(date).ToString("00"));
        }

        public static string ToGregorian(this string date, bool isPersian)
        {
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));
            PersianCalendar fa = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, fa);
            return dt.ToString("yyyy/MM/dd");
        }
    }
}
