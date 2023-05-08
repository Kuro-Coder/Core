using Core.Models;

namespace Core.Utilities.FileExtensions
{
    public static class FileExtensions
    {
        public static FileUploadResponse FileValidator(string userInfo, string fileType)//, System.Web.HttpPostedFile postedFile)
        {
            var response = new FileUploadResponse();
            var getAccess = ValidTypeOfFile.FileTypeHaveAccess(Path.GetExtension(fileType));
            if (getAccess.HaveAccess == false)
                return response;

            response.FileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "--" + userInfo + "--" + getAccess.FilePathType;
            response.FileType = getAccess.FileType;

            return response;
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

    }
}
