using System;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Input;
using Kursverwaltung.Models.Utilities;

namespace Kursverwaltung.ViewModels
{
    public class AdminAnmeldungVM : INotifyPropertyChanged
    {
        private string adminemail;
        private string password;
        //Für PasswordBox
        public SecureString SecurePassword { private get; set; }

        public string AdminEmail
        {
            get { return adminemail; }
            set
            {
                adminemail = value;
                OnPropertyChanged(nameof(AdminEmail));
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

        public ICommand AnmeldenCommand { get; private set; }

        public AdminAnmeldungVM()
        {
            AnmeldenCommand = new RelayCommand(Anmelden);
        }

        private void Anmelden(object parameter)
        {
            if (IstAdmin(AdminEmail, Password))
            {
                MessageBox.Show("Anmeldung erfolgt");
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
            }
        }

        private bool IstAdmin(string username, string password)
        {
            return (username == "admin" && password == "adminpassword");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
