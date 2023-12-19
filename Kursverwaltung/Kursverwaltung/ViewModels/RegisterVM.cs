using System;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Input;
using Kursverwaltung.Models.Utilities;

namespace Kursverwaltung.ViewModels
{
    class RegisterVM : INotifyPropertyChanged
    {
        private string email;
        private string firstname;
        private string lastname;
        private DateTime birthday;
        private string password;
        public SecureString SecurePassword { private get; set; }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged(nameof(Birthday));
            }
        }

        private ICommand _registerAccount;
        public ICommand RegisterCommand
        {
            get
            {
                if (_registerAccount == null)
                    _registerAccount = new RelayCommand(RegisterAccount);
                return _registerAccount;
            }
        }

        private void RegisterAccount(object parameter)
        {
            MessageBox.Show("Created new account");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
