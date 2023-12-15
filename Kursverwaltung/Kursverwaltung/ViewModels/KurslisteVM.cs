using System.ComponentModel;

namespace Kursverwaltung.ViewModels
{
    public class KurslisteVM : INotifyPropertyChanged
    {
        private Models.Kursliste kursliste;

        public Models.Kursliste Kursliste
        {
            get { return kursliste; }
            set
            {
                kursliste = value;
                OnPropertyChanged(nameof(Kursliste));
            }
        }

        public KurslisteVM()
        {
            Kursliste = new Models.Kursliste();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
