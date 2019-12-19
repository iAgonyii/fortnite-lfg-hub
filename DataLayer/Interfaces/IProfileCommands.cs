using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface IProfileCommands
    {
        MySqlDataReader reader { get; set; }
        ProfileDTO GetProfileData(string input);
        List<ProfileDTO> GetProfiles();
        void UpdateProfile(ProfileDTO dto);
        void RegisterNewProfile(ProfileDTO dto);
        bool CheckCredentials(string username, string password);
    }
}
