using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Kursverwaltung
{
    public class AnmeldungVM : INotifyPropertyChanged
    {
        public ICommand UserCommand { get; private set; }
        public ICommand AdminCommand { get; private set; }

        public AnmeldungVM()
        {
            UserCommand = new RelayCommand(UserButtonClick);
            AdminCommand = new RelayCommand(AdminButtonClick);
        }

        private void UserButtonClick(object obj)
        {
            MessageBox.Show("Anmeldung als User");
        }

        private void AdminButtonClick(object obj)
        {
            var adminAnmeldungVM = new ViewModels.AdminAnmeldungVM(); 
            var adminAnmeldungView = new Views.AdminAnmeldungView();
            adminAnmeldungView.DataContext = adminAnmeldungVM; 

            adminAnmeldungView.Show(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
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

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);

        public void Execute(object parameter) => _execute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
