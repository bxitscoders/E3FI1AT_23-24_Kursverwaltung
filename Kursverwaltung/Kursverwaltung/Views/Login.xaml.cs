using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursverwaltung.Views
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new ViewModels.AdminAnmeldungVM();
        }

        private void PWBoxChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModels.AdminAnmeldungVM viewModel)
            {
                if (sender is PasswordBox passwordBox)
                {
                    viewModel.SecurePassword = passwordBox.SecurePassword;
                }
            }
        }
    }
}
