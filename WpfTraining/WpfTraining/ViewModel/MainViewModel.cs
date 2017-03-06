// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System;
using System.Collections.ObjectModel;
using WpfTraining.Model;
using WpfTraining.Service.Interface;
using WpfTraining.Utils;
using WpfTraining.ViewModel.Base;

namespace WpfTraining.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Variables
        readonly IUserManager _userManager;
        ObservableCollection<User> _allUsers;
        User _selectedUser;
        #endregion

        #region Properties
        public ObservableCollection<User> AllUsers
        {
            get { return _allUsers; }
            set
            {
                _allUsers = value;
                NotifyOfPropertyChange(() => this.AllUsers);
            }
        }


        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                NotifyOfPropertyChange(() =>this.SelectedUser);
                NotifyOfPropertyChange(() =>this.PhotoPreview);
                NotifyOfPropertyChange(() =>this.CanEditUser);
                NotifyOfPropertyChange(() =>this.CanRemove);
            }
        }

        public string PhotoPreview => PhotoSourceLocator.GetPhotoPath(this.SelectedUser?.PhotoName);
        public bool CanEditUser => this.SelectedUser != null;
        public bool CanRemove => this.SelectedUser != null;

        #endregion

        public MainViewModel(INavigator navigator, IUserManager userManager) : base(navigator)
        {
            _userManager = userManager;
            this.AllUsers = _userManager.AllUsers;
        }

        public void AddUser()
        {
            _userManager.CurrentSelectedUser = null;
            _navigator.NavigateTo<UserDetailsViewModel>();
        }

        public void EditUser()
        {
            _userManager.CurrentSelectedUser = this.SelectedUser;
            _navigator.NavigateTo<UserDetailsViewModel>();
        }

        public void Remove()
        {
            this.AllUsers.Remove(this.SelectedUser);
            _userManager.Save();
        }
    }
}
