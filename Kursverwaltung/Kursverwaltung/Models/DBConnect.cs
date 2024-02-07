using System;
using MySql.Data.MySqlClient;

namespace Kursverwaltung.Models
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Connection // Diese Eigenschaft wurde hinzugefügt
        {
            get { return connection; }
        }

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "Kursverwaltung";
            database = "Kursverwaltung";
            uid = "Benutzername";
            password = "Passwort";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Select()
        {
            string query = "SELECT * FROM user";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                this.CloseConnection();
            }
        }
    }
}
