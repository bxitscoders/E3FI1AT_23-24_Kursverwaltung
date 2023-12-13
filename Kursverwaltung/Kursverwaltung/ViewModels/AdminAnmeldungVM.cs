using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Kursverwaltung.ViewModels
{
    public class AdminAnmeldungVM : INotifyPropertyChanged
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
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

        public ICommand AnmeldenCommand { get; private set; }

        public AdminAnmeldungVM()
        {
            AnmeldenCommand = new RelayCommand(Anmelden);
        }

        private void Anmelden(object parameter)
        {

            if (IstAdmin(Username, Password))
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

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object parameter) => _execute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
