using System;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Kursverwaltung.Models.Utilities;

namespace Kursverwaltung.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string email;
        private string password;


        public string Email
        {
            get { return email;  }
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

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                    _loginCommand = new RelayCommand(UserLogin);
                return _loginCommand;
            }
        }

        private void UserLogin(object parameter)
        {
            Password = ((PasswordBox) parameter).Password;
            if (isAdmin(email, password))
            {
                MessageBox.Show("200: User is Admin.");
            } else
            {
                MessageBox.Show("200: User is User");
            }
        }

        private bool isAdmin(string email, string password)
        {
            return (email == "admin" && password == "admin"); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
