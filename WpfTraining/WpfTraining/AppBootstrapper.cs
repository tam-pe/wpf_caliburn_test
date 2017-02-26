// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

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
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
