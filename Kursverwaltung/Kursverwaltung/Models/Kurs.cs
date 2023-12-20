using System;

namespace Kursverwaltung.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Anmeldefrist { get; set; }
        public int Dauer { get; set; }
        public int AktuelleTeilnehmerzahl { get; set; }
        public int MaximaleTeilnehmerzahl { get; set; }
        public int AdminId { get; set; }

        public string TeilnehmerInfo
        {
            get { return $"{AktuelleTeilnehmerzahl}/{MaximaleTeilnehmerzahl}"; }
        }
    }
}
