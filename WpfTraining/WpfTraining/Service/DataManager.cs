// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using WpfTraining.Model;
using WpfTraining.Service.Interface;

namespace WpfTraining.Service
{
    internal class DataManager : IDataManager
    {
        #region Implementation of IDataManager
        public IEnumerable<User> LoadUsers()
        {
            IEnumerable<User> result  = new List<User>();
            var pathToFile = GetPathToUserJson();
            if (File.Exists(pathToFile))
            {
                result = JsonConvert.DeserializeObject<IEnumerable<User>>(File.ReadAllText(pathToFile));
            }
            return result;
        }

        public void SaveUsers(IEnumerable<User> users)
        {
            var json = JsonConvert.SerializeObject(users);
            var pathToFile = GetPathToUserJson();
            File.WriteAllText(pathToFile, json);
        }
        #endregion

        #region Private method
        string GetPathToUserJson()
        {
            var dir = Constants.GetPathToUserJsonFolder();
            return Path.Combine(dir, "User.json");
        }
        #endregion
    }
}
