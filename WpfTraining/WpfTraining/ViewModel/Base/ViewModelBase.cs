// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using Caliburn.Micro;
using WpfTraining.Service.Interface;

namespace WpfTraining.ViewModel.Base
{
    internal class ViewModelBase: Screen
    {
        protected readonly INavigator _navigator;

        public ViewModelBase(INavigator navigator)
        {
            _navigator = navigator;
        }
    }
}
