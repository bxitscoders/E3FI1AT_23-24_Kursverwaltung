using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Kursverwaltung.Models
{
    public class DBConnect
    {
        public MySqlConnection connection { get; private set; }
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "Kursverwaltung"; 
            database = "test"; 
            uid = "root"; 
            password = ""; 
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
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

        private bool CloseConnection()
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
