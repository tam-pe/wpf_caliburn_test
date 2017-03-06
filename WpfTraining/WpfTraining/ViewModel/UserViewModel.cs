// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using System;
using Caliburn.Micro;
using WpfTraining.Model;

namespace WpfTraining.ViewModel
{
    internal class UserViewModel : PropertyChangedBase
    {
        #region Variables
        string _firstName = "First Name";
        string _lastName = "Last Name";
        DateTime _dateofBirth = DateTime.Today;
        string _photoName = string.Empty;
        #endregion

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => this.FirstName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => this.LastName);
            }
        }

        public DateTime DateofBirth
        {
            get { return _dateofBirth; }
            set
            {
                _dateofBirth = value;
                NotifyOfPropertyChange(() => this.DateofBirth);
            }
        }

        public string PhotoName
        {
            get { return _photoName; }
            set
            {
                _photoName = value;
                NotifyOfPropertyChange(() => this.PhotoName);
            }
        }
        #endregion

        #region Constrcut & Desctruct
        internal UserViewModel(User user = null)
        {
            if (user != null)
            {
                this.FirstName = user.FirstName;
                this.LastName = user.LastName;
                this.DateofBirth = user.DateofBirth;
                this.PhotoName = user.PhotoName;
            }
        }

        internal User GetUser()
        {
            return new User()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                DateofBirth = this.DateofBirth,
                PhotoName = this.PhotoName
            };
        }
        #endregion
    }
}
