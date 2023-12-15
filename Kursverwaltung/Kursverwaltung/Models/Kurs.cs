using System;

namespace Kursverwaltung.Models
{
    public class Kurs
    {
        public string Name { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Anmeldefrist { get; set; }
        public int AktuelleTeilnehmerzahl { get; set; }
        public int MaximaleTeilnehmerzahl { get; set; }

        public string TeilnehmerInfo
        {
            get { return $"{AktuelleTeilnehmerzahl}/{MaximaleTeilnehmerzahl}"; }
        }
    }
}
