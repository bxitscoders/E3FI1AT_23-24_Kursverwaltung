using System;
using System.Collections.ObjectModel;

namespace Kursverwaltung.Models
{
    public class Kursliste
    {
        public ObservableCollection<Kurs> Kurse { get; set; }

        public Kursliste()
        {
            Kurse = new ObservableCollection<Kurs>();

            Kurse.Add(new Kurs
            {
                //Platzhalter -> Ersetzen durch Abruf aus DB
                Name = "Beispielkurs 1",
                Datum = new DateTime(2023, 12, 31),
                Anmeldefrist = new DateTime(2023, 12, 28),
                AktuelleTeilnehmerzahl = 5,
                MaximaleTeilnehmerzahl = 15
            });

            Kurse.Add(new Kurs
            {
                //Platzhalter -> Ersetzen durch Abruf aus DB

                Name = "Beispielkurs 2",
                Datum = new DateTime(2024, 1, 15),
                Anmeldefrist = new DateTime(2024, 1, 10),
                AktuelleTeilnehmerzahl = 10,
                MaximaleTeilnehmerzahl = 20
            });


        }
    }
}
