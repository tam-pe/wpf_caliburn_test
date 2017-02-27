// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System;
using WpfTraining.Model;
using WpfTraining.Service.Interface;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Variables
        private readonly IUserManager _userManager;
        #endregion

        public MainViewModel(INavigator navigator, IUserManager userManager) : base(navigator)
        {
            _userManager = userManager;
        }

        public void Personal()
        {
            _navigator.NavigateTo<UserDetailsViewModel>();
        }

        public void AddUser()
        {
            for (int i = 0; i < 5; i++)
            {
                var us = new User()
                {
                    FirstName = "aasd",
                    LasName = "f111",
                    DateofBirth = DateTime.Today,
                    PathToPhoto = String.Empty
                };
                _userManager.AllUsers.Add(us);
            }
            _userManager.Save();
        }

        public void EditUser()
        {
               
        }

        public void RemoveRemove()
        {
            
        }
    }
}
