using Core.Models;

namespace Core.Utilities
{
    public static class FileExtensions
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

        public static string FileContentType(string fileName)
        {
            string separator = "--";
            string[] tokens = fileName.Split(separator);
            var contentType = tokens[2];
            if (contentType == ".png")
                contentType = "image/png";
            else if (contentType == ".jpg")
                contentType = "image/jpeg";
            else if (contentType == ".mp3")
                contentType = "audio/mpeg";
            return contentType;
        }

        public static string Replacing(string str)
        {
            var newStr = str.Replace('-', '_');
            newStr = newStr.Replace('/', '-');
            return newStr;
        }

        public static string[] Split(this string str, string separator)
        {
            return str.Split(new string[] { separator }, StringSplitOptions.None);
        }

        public static FileUploadResponse FileValidator(string userInfo, string fileType)//, System.Web.HttpPostedFile postedFile)
        {
            var response = new FileUploadResponse();
            var getAccess = FileTypeHaveAccess(Path.GetExtension(fileType));
            if (getAccess.HaveAccess == false)
                return response;

            response.FileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "--" + userInfo + "--" + getAccess.FilePathType;
            response.FileType = getAccess.FileType;

            return response;
        }

        public static bool IsValidFileSize(long len)
        {
            var maxSize = 5097152;
            if (len > maxSize)
                return false;

            return true;
        }

        public static FileTypeAccess FileTypeHaveAccess(string fileType)
        {
            var result = new FileTypeAccess();
            switch (fileType)
            {
                case ".mp3":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".flac":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".aac":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".wav":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".png":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".PNG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".jpg":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".JPG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".svg":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".SVG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
            }
            return result;
        }
    }
}
