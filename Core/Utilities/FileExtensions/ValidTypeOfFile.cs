using Core.Models;

namespace Core.Utilities.FileExtensions
{
    public static class ValidTypeOfFile
    {
        public static FileTypeAccess FileTypeHaveAccess(string fileType)
        {
            var result = new FileTypeAccess();

            switch (fileType)
            {
                case ".mp3":
                case ".MP3":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case "blob":
                case "BLOB":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".m4a":
                case ".M4A":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".flac":
                case ".FLAC":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".aac":
                case ".AAC":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".wav":
                case ".WAV":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp3";
                    result.FileType = "audio/mpeg";
                    break;
                case ".png":
                case ".PNG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".heif":
                case ".HEIF":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".ico":
                case ".ICO":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".jpg":
                case ".JPG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".webp":
                case ".WEBP":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".tiff":
                case ".TIFF":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".svg":
                case ".SVG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".jpe":
                case ".JPE":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".jpeg":
                case ".JPEG":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".bmp":
                case ".BMP":
                    result.HaveAccess = true;
                    result.FilePathType = ".png";
                    result.FileType = "image/png";
                    break;
                case ".mp4":
                case ".MP4":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".m4v":
                case ".M4V":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".3gp":
                case ".3GP":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".mpv":
                case ".MPV":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".mov":
                case ".MOV":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".hevc":
                case ".HEVC":
                    result.HaveAccess = true;
                    result.FilePathType = ".mp4";
                    result.FileType = "video/mp4";
                    break;
                case ".docx":
                    result.HaveAccess = true;
                    result.FilePathType = ".docx";
                    result.FileType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case ".xlsx":
                    result.HaveAccess = true;
                    result.FilePathType = ".docx";
                    result.FileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case ".rar":
                    result.HaveAccess = true;
                    result.FilePathType = ".rar";
                    result.FileType = "application/octet-stream";
                    break;
                case ".zip":
                    result.HaveAccess = true;
                    result.FilePathType = ".zip";
                    result.FileType = "application/x-zip-compressed";
                    break;
                case ".pdf":
                    result.HaveAccess = true;
                    result.FilePathType = ".pdf";
                    result.FileType = "application/pdf";
                    break;
                case ".txt":
                    result.HaveAccess = true;
                    result.FilePathType = ".txt";
                    result.FileType = "text/plain";
                    break;
                case ".html":
                    result.HaveAccess = true;
                    result.FilePathType = ".html";
                    result.FileType = "text/html";
                    break;
            }
            return result;
        }
    }
}
