using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Kursverwaltung.Models.Utilities;
using System.Security;
using Kursverwaltung.Views;

namespace Kursverwaltung.ViewModels
{
    public class UserAnmeldungVM : INotifyPropertyChanged
    {
        private string _useremail;
        public string UserEMail
        {
            get { return _useremail; }
            set
            {
                _useremail = value;
                OnPropertyChanged();
            }
        }

        //Für PasswordBox 
        public SecureString SecurePassword { private get; set; } 


        public ICommand AnmeldenCommand { get; private set; }
        public ICommand RegistrierenCommand { get; private set; }


        public UserAnmeldungVM()
        {
            AnmeldenCommand = new RelayCommand(Anmelden);
            RegistrierenCommand = new RelayCommand(Registrieren);
        }

        private void Anmelden(object parameter)
        {

            MessageBox.Show("Anmelden geklickt");
        }

        private void Registrieren(object parameter)
        {
            var personalDataVM = new PersonalDataVM();
            var personalDataView = new PersonalDataView();
            personalDataView.DataContext = personalDataVM;

            personalDataView.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
