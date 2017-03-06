// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.IO;

namespace WpfTraining.Utils
{
    internal static class PhotoSourceLocator
    {
        public static string GetPhotoPath(string path)
        {
            var pathToPhoto = string.Empty;
            if (path != null)
            {
                if (File.Exists(path))
                {
                    return path;
                }
                pathToPhoto = Path.Combine(Constants.GetPathToPhotoFolder(), path);
            }
            return File.Exists(pathToPhoto) ? pathToPhoto : "/WpfTraining;component/empty_photo.png";
        }

        public static void AddNewPhoto(string photoPath)
        {
            
        }
    }
}
