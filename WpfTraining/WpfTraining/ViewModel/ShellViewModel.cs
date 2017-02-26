// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using Caliburn.Micro;
using WpfTraining.DependencyInjection;
using WpfTraining.Service.Interface;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class ShellViewModel : Conductor<IScreen>.Collection.OneActive, INavigator
    {
        #region Variables
        readonly Context _context;
        #endregion

        #region Construct & Destruct
        public ShellViewModel()
        {
            _context = new Context(this);
            NavigateTo<MainViewModel>();
        }
        #endregion

        #region Implementation of INavigator
        public void NavigateTo<T>() where T : ViewModelBase
        {
            this.ActiveItem = _context.Create<T>();
        }
        #endregion
    }
}
