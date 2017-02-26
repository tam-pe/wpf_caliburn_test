// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using WpfTraining.Model;
using WpfTraining.Service.Interface;

namespace WpfTraining.Service
{
    internal class DataManager : IDataManager
    {
        #region Implementation of IDataManager
        public IEnumerable<User> LoadUsers()
        {
            throw new System.NotImplementedException();
        }

        public void SaveUsers(IEnumerable<User> users)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}