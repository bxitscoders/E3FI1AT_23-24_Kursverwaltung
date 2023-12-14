using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Kursverwaltung.Models.Utilities;

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
            var userAnmeldungVM = new ViewModels.UserAnmeldungVM();
            var userAnmeldungView = new Views.UserAnmeldungView
            {
                DataContext = userAnmeldungVM
            };

            userAnmeldungView.Show();
        }

        private void AdminButtonClick(object obj)
        {
            var adminAnmeldungVM = new ViewModels.AdminAnmeldungVM();
            var adminAnmeldungView = new Views.AdminAnmeldungView
            {
                DataContext = adminAnmeldungVM
            };

            adminAnmeldungView.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
