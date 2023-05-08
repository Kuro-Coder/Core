
namespace Core.Utilities
{
    public static class Base64Convertor
    {
        public static string ToBase64(byte[] fileContent)
        {
            var base64String = Convert.ToBase64String(fileContent);
            return $"{base64String}";
        }

        public static string ToBase64(byte[] fileContent, string contentType)
        {
            var base64String = Convert.ToBase64String(fileContent);
            return $"{contentType};{base64String}";
        }
    }
}
