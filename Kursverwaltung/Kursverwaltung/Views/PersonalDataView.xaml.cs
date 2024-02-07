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
using Kursverwaltung.ViewModels;

namespace Kursverwaltung.Views
{
    /// <summary>
    /// Interaktionslogik für PersonalData.xaml
    /// </summary>
    public partial class PersonalDataView : Window
    {
        public PersonalDataView()
        {
            InitializeComponent();
            DataContext = new ViewModels.PersonalDataVM();
        }
    }
}
