using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IProfileCommands
    {
        void UpdateProfileInfo(ProfileDTO dto);
        void RegisterNewProfile(ProfileDTO dto);
        bool CheckCredentials(ProfileDTO dto);
    }
}
