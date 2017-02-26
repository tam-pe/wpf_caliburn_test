// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.ObjectModel;
using WpfTraining.Model;
using WpfTraining.Service.Interface;

namespace WpfTraining.Service
{
    internal class UserManager : IUserManager
    {
        #region Properties
        public ObservableCollection<User> AllUsers { get; set; }
        public User CurrentSelectedUser { get; set; }
        #endregion

        #region public method
        public void Save()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}