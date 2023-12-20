using MySql.Data.MySqlClient;
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

            GetCourseData();
        }

        public void GetCourseData()
        {
            DBConnect dbConnect = new DBConnect();
            string query = "SELECT * FROM course";
            MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
            dbConnect.connection.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            Kurs course = new Kurs();

            while (dataReader.Read())
            {
                ReadCourseData(course, dataReader);
                Kurse.Add(course);
            }
        }

        private static void ReadCourseData(Kurs course, MySqlDataReader dataReader)
        {
            course.KursId = Convert.ToInt32(dataReader["courseId"]);
            course.Name = dataReader["name"].ToString();
            course.Beschreibung = dataReader["description"].ToString();
            course.MaximaleTeilnehmerzahl = Convert.ToInt32(dataReader["maxUsers"]);
            course.Datum = Convert.ToDateTime(dataReader["startDateTime"]);
            course.Dauer = Convert.ToInt32(dataReader["duration"]);
            course.Anmeldefrist = Convert.ToDateTime(dataReader["registrDeadline"]);
            course.AdminId = Convert.ToInt32(dataReader["adminId"]);
        }
    }
}
