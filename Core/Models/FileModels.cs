
namespace Core.Models
{
    public class FileUploadResponse
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Message { get; set; }
    }

    /// <summary>
    /// مدلی برای بررسی دسترسی آپلود فایل
    /// </summary>
    public class FileTypeAccess
    {
        public bool HaveAccess { get; set; }
        public string FilePathType { get; set; }
        public string FileType { get; set; }
    }
}
