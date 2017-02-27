// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.IO;

namespace WpfTraining.Utils
{
    internal static class PhotoSourceLocator
    {
        public static string GetPhotoPath(string photoName)
        {
            var pathToPhoto = string.Empty;
            if (photoName != null)
            {
                pathToPhoto = Path.Combine(Constants.PathToPhotoFolder, photoName);
            }
            return File.Exists(pathToPhoto) ? pathToPhoto : "/WpfTraining;component/empty_photo.png";
        }
    }
}
