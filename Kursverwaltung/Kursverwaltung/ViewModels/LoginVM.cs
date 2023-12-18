using System;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Input;
using Kursverwaltung.Models.Utilities;

namespace Kursverwaltung.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string username;
        private string password;

        public SecureString SecurePassword { private get; set; }

        public string Username
        {
            get { return username;  }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
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

        public ICommand LoginCommand { get; private set; }

        public LoginVM()
        {
            LoginCommand = new RelayCommand(UserLogin);
        }

        private void UserLogin(object parameter)
        {
            if (isAdmin(Username, Password))
            {
                MessageBox.Show("200: User is Admin.");
            } else
            {
                MessageBox.Show("200: User is User");
            }
        }

        private bool isAdmin(string username, string password)
        {
            return (username == "admin" && password == "admin"); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
