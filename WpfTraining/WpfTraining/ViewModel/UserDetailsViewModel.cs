// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System;
using System.IO;
using Microsoft.Win32;
using WpfTraining.Model;
using WpfTraining.Service.Interface;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class UserDetailsViewModel : ViewModelBase
    {

        #region Variables
        UserViewModel _user;
        bool _isNewUser;
        IUserManager _userManager;
        #endregion

        #region Properties

        public UserViewModel User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyOfPropertyChange(() => this.User);
            }
        }

        #endregion
        
        #region Construct & Destruct
        public UserDetailsViewModel(INavigator navigator, IUserManager userManager) : base(navigator)
        {
            _userManager = userManager;
            if (_userManager.CurrentSelectedUser != null)
            {
                this.User = new UserViewModel(_userManager.CurrentSelectedUser);
            }
            else
            {
                _isNewUser = true;
                this.User = new UserViewModel();
            }
        }
        #endregion

        #region Public method
        public void SelectPhoto()
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Image (*.jpg)|*.jpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == true)
            {
                this.User.PhotoName = openFileDialog.FileName;
            }
        }

        public void Cancel()
        {
           ReturnToMain();
        }

        public void Save()
        {
            if (_isNewUser)
            {
                _userManager.AddUser(this.User.GetUser());
            }
            else
            {
                _userManager.EditUser(this.User.GetUser());
            }
            ReturnToMain();
        }

        void ReturnToMain()
        {
            _navigator.NavigateTo<MainViewModel>();
        }
        #endregion
    }
}
