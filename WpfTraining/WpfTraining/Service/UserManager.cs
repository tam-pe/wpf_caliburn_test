// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.ObjectModel;
using WpfTraining.Model;
using WpfTraining.Service.Interface;

namespace WpfTraining.Service
{
    internal class UserManager : IUserManager
    {
        #region Variables
        private readonly IDataManager _dataManager;
        #endregion

        #region Properties
        public ObservableCollection<User> AllUsers { get; set; }
        public User CurrentSelectedUser { get; set; }
        #endregion

        #region Construct & Destruct

        public UserManager(IDataManager dataManager)
        {
            _dataManager = dataManager;
            this.AllUsers = new ObservableCollection<User>(_dataManager.LoadUsers());
        }
        #endregion

        #region Public method
        public void Save()
        {
            _dataManager.SaveUsers(this.AllUsers);
        }
        #endregion
    }
}
