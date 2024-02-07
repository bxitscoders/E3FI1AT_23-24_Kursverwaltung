using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Kursverwaltung.Models;
using System.Windows.Input;

namespace Kursverwaltung.ViewModels
{
    public class PersonalDataVM : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthdate;
        private string _email;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                _birthdate = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public RegistrationModel RegistrationModel { get; private set; }

        public PersonalDataVM()
        {
            RegistrationModel = new RegistrationModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
