
namespace Core.Utilities
{
    /// <summary>
    /// Summary description for NaCodeValid
    /// </summary>
    public static class CheckId
    {
        public static bool IsValid(string naCode)
        {
            if (naCode.Length != 10)
            {
                return false;
            }
            if (naCode.Contains("0000000000") ||
                naCode.Contains("1111111111") ||
                naCode.Contains("2222222222") ||
                naCode.Contains("3333333333") ||
                naCode.Contains("4444444444") ||
                naCode.Contains("5555555555") ||
                naCode.Contains("6666666666") ||
                naCode.Contains("7777777777") ||
                naCode.Contains("8888888888") ||
                naCode.Contains("9999999999") ||
                naCode.Contains("0123456789") ||
                naCode.Contains("9876543210"))
            {
                return false;
            }
            char[] chArray = naCode.ToCharArray();
            int num = Convert.ToInt32(chArray[0].ToString()) * 10;
            int num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            int num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            int num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            int num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            int num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            int num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            int num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            int num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            int num10 = Convert.ToInt32(chArray[9].ToString());
            int num11 = (((((((num + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
            int num12 = num11 % 11;
            bool flag = ((num12 < 2) && (num10 == num12)) || ((num12 >= 2) && ((11 - num12) == num10));
            if (flag)
            {
                return true;
            }
            return false;
        }
    }
}
