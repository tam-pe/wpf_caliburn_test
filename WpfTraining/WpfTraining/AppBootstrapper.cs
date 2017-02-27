// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using WpfTraining.ViewModel;

namespace WpfTraining
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            var config = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViewModels = "ViewModel",
                DefaultSubNamespaceForViews = "View"
            };
            ViewModelLocator.ConfigureTypeMappings(config);
            ViewLocator.ConfigureTypeMappings(config);
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var settings = new Dictionary<string, object>
            {
                { "SizeToContent", SizeToContent.Manual },
                { "MinHeight" , 350  },
                { "MinWidth"  , 500 },
                { "MaxHeight" , 700  },
                { "MaxWidth"  , 1000 },
                { "Height" , 350  },
                { "Width"  , 500 },
                { "WindowStyle", WindowStyle.ThreeDBorderWindow },
                { "WindowStartupLocation", WindowStartupLocation.CenterScreen },
                { "Title", "Caliburn Training" }
            };
            DisplayRootViewFor<ShellViewModel>(settings);
        }
    }
}
