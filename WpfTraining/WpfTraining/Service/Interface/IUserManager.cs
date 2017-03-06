// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.ObjectModel;
using WpfTraining.Model;

namespace WpfTraining.Service.Interface
{
    internal interface IUserManager
    {
        ObservableCollection<User> AllUsers { get; set; }
        User CurrentSelectedUser { get; set; }
        void AddUser(User user);
        void EditUser(User user);
        void Save();
    }
}
