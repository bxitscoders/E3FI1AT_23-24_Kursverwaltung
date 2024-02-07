using System;
using MySql.Data.MySqlClient;

namespace Kursverwaltung.Models
{
    public class RegistrationModel
    {
        private DBConnect _dbConnect;

        public RegistrationModel()
        {
            _dbConnect = new DBConnect();
        }

        public void Register(string firstName, string lastName, DateTime birthDate, string email)
        {
            try
            {
                if (_dbConnect.OpenConnection())
                {
                    string query = $"INSERT INTO user (FirstName, LastName, BirthDate, Email) VALUES ('{firstName}', '{lastName}', '{birthDate:yyyy-MM-dd}', '{email}')";

                    MySqlCommand cmd = new MySqlCommand(query, _dbConnect.Connection);
                    cmd.ExecuteNonQuery();

                    _dbConnect.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
