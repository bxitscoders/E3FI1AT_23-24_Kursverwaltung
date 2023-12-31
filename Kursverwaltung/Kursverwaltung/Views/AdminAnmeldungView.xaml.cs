﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kursverwaltung.ViewModels;

namespace Kursverwaltung.Views
{
    public partial class AdminAnmeldungView : Window
    {
        public AdminAnmeldungView()
        {
            InitializeComponent();
            DataContext = new ViewModels.AdminAnmeldungVM();
        }

        /*PasswordBox lässt sich aus Sicherheitsgründen anscheinend nicht so einfach über DataBinding binden, 
        * daher habe ich versucht die Lösung von https://stackoverflow.com/a/25001115 abzuleiten*/

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
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
