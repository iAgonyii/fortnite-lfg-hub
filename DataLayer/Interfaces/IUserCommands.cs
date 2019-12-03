using DataLayer.DTOs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    interface IUserCommands
    {
        void SaveNewUser(UserDTO dto);
        UserDTO GetUserData();
        bool CheckCredentials(string u, string p);
    }
}
