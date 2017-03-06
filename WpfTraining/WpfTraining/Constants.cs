// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.IO;
using System.Reflection;

namespace WpfTraining
{
    public static class Constants
    {
        public static readonly string AppDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

        public static string GetPathToPhotoFolder()
        {
            var path =  Path.Combine(AppDirectory, "app_data", "photo");
            EnsureFolder(path);
            return path;
        }

        public static string GetPathToUserJsonFolder()
        {
            var path = Path.Combine(AppDirectory, "app_data");
            EnsureFolder(path);
            return path;
        }

        static void EnsureFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
