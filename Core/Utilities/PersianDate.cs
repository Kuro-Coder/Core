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

        public static string ToGregorian(this string date)
        {
            date = date.PersianToEnglish();
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));
            PersianCalendar fa = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, fa);
            return dt.ToString("yyyy/MM/dd");
        }

        public static string PersianToEnglish(this string persianStr)
        {
            Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
            {
                ['۰'] = '0',
                ['۱'] = '1',
                ['۲'] = '2',
                ['۳'] = '3',
                ['۴'] = '4',
                ['۵'] = '5',
                ['۶'] = '6',
                ['۷'] = '7',
                ['۸'] = '8',
                ['۹'] = '9'
            };
            foreach (var item in persianStr)
            {
                if (LettersDictionary.Any(x => x.Key == item))
                {
                    persianStr = persianStr.Replace(item, LettersDictionary[item]);
                }
            }
            return persianStr;
        }
    }
}
