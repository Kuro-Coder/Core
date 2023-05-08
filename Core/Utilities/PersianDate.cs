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

    }
}
