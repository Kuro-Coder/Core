
namespace Core.Utilities
{
    public static class StringUtilities
    {
        public static string MakeUpperText(string text)
        {
            var result = text.ToUpper();
            return result;
        }

        public static string MakeLowerText(string text)
        {
            var result = text.ToLower();
            return result;
        }
    }
}
