using Kursverwaltung.ViewModels;
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
    public partial class UserAnmeldungView : Window
    {
        public UserAnmeldungView()
        {
            InitializeComponent();
            DataContext = new UserAnmeldungVM();
        }

        /*PasswordBox lässt sich aus Sicherheitsgründen anscheinend nicht so einfach über DataBinding binden, 
         * daher habe ich versucht die Lösung von https://stackoverflow.com/a/25001115 abzuleiten*/
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModels.UserAnmeldungVM viewModel)
            {
                if (sender is PasswordBox passwordBox)
                {
                    viewModel.SecurePassword = passwordBox.SecurePassword;
                }
            }
        }
    }

}
