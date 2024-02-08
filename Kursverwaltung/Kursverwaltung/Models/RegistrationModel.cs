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

        public void Register(string firstName, string lastName, DateTime dateOfBirth, string email, string password)
        {
            try
            {
                if (_dbConnect.OpenConnection())
                {
                    string query = "INSERT INTO user (FirstName, LastName, dateOfBirth, Email, Password) VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @Password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, _dbConnect.Connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                    }

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
