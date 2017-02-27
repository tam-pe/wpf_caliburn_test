// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.IO;
using System.Reflection;

namespace WpfTraining
{
    public static class Constants
    {
        public static readonly string AppDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
        public static readonly string PathToPhotoFolder = Path.Combine(AppDirectory, "app_data", "photo");
        public static readonly string PathToUserJsonFolder = Path.Combine(AppDirectory, "app_data");

    }
}
