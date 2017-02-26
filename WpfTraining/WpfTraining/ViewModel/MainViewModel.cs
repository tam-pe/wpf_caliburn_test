// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using WpfTraining.Service.Interface;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigator navigator) : base(navigator)
        {

        }


        public void Personal()
        {
            _navigator.NavigateTo<UserDetailsViewModel>();
        }
    }
}
