﻿using System;
using System.Collections.Generic;
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
            server = "127.0.0.1";
            database = "kvdb";
            uid = "root";
            password = "";
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

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            string query = "SELECT * FROM course";

            if (this.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Course course = new Course
                            {
                                CourseId = Convert.ToInt32(dataReader["courseId"]),
                                Name = dataReader["name"].ToString(),
                                Description = dataReader["description"].ToString(),
                                MaxUsers = Convert.ToInt32(dataReader["maxUsers"]),
                                CurrentUsers = Convert.ToInt32(dataReader["currentUsers"]),
                                StartDateTime = Convert.ToDateTime(dataReader["startDateTime"]),
                                Duration = Convert.ToInt32(dataReader["duration"]),
                                RegistrDeadline = Convert.ToDateTime(dataReader["registrDeadline"]),
                                AdminId = Convert.ToInt32(dataReader["adminId"])
                            };

                            courses.Add(course);
                        }
                    }
                }

                this.CloseConnection();
            }

            return courses;
        }

        public bool CheckLogin(string email, string password)
        {
            bool res = false;

            if (this.OpenConnection())
            {
                string query = $"Select * from user where email='{email}' and password='{password}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    res = true;
                }

                this.CloseConnection();
            }

            return res;
        }
    }
}