// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using WpfTraining.Model;

namespace WpfTraining.Service.Interface
{
    internal interface IDataManager
    {
        IEnumerable<User> LoadUsers();
        void SaveUsers(IEnumerable<User> users);
    }
}
