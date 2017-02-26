// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using WpfTraining.ViewModel.Base;

namespace WpfTraining.Service.Interface
{
    internal interface INavigator
    {
        void NavigateTo<T>() where T: ViewModelBase;
    }
}
