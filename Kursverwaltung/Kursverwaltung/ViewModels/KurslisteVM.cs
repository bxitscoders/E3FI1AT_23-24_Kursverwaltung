using System.Collections.ObjectModel;
using System.ComponentModel;
using Kursverwaltung.Models;

namespace Kursverwaltung.ViewModels
{
    public class KurslisteVM : INotifyPropertyChanged
    {
        private ObservableCollection<Course> courses;

        public ObservableCollection<Course> Courses
        {
            get { return courses; }
            set
            {
                courses = value;
                OnPropertyChanged(nameof(Courses));
            }
        }

        public KurslisteVM()
        {
            DBConnect dbConnect = new DBConnect();

            Courses = new ObservableCollection<Course>(dbConnect.GetCourses());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
