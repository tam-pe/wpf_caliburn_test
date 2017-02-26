// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using WpfTraining.Service.Interface;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class UserDetailsViewModel : ViewModelBase
    {
        public UserDetailsViewModel(INavigator navigator) : base(navigator)
        {
        }

        public void GoToMain()
        {
            _navigator.NavigateTo<MainViewModel>();
        }
    }
}
