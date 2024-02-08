using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Kursverwaltung.Models;
using Kursverwaltung.Models.Utilities;

namespace Kursverwaltung.ViewModels
{
    public class PersonalDataVM : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthdate;
        private string _email;
        private string _password;
        private RelayCommand _registerCommand;

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

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand RegisterCommand
        {
            get
            {
                if (_registerCommand == null)
                {
                    _registerCommand = new RelayCommand(param => Register(), param => CanRegister());
                }
                return _registerCommand;
            }
        }

        public RegistrationModel RegistrationModel { get; private set; }

        public PersonalDataVM()
        {
            RegistrationModel = new RegistrationModel();
        }

        private void Register()
        {
            RegistrationModel.Register(FirstName, LastName, Birthdate, Email, Password);
        }

        private bool CanRegister()
        {
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(Email) && Birthdate != default(DateTime) && !string.IsNullOrEmpty(Password);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
