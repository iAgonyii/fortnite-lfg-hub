using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.DTOs;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class UserCommands: IUserCommands
    {
        MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        MySqlCommand command;
        MySqlDataReader reader;

        public bool CheckCredentials(string username, string password)
        {
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("SELECT * FROM Profile where Username=@username AND Password=@password",conn))
                {
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);

                    using(reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public UserDTO GetUserData()
        {
            UserDTO dto = new UserDTO();





            return dto;
        }

        public void SaveNewUser(UserDTO dto)
        {
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("INSERT INTO Profile(Username, Password) VALUES(@username, @password)",conn))
                {
                    command.Parameters.AddWithValue("username", dto.Username);
                    command.Parameters.AddWithValue("password", dto.Password);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
