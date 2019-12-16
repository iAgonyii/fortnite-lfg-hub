﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface IProfileCommands
    {
        ProfileDTO GetProfileData(string input);
        List<ProfileDTO> GetProfiles();
        void UpdateProfile(ProfileDTO dto);
        void RegisterNewProfile(ProfileDTO dto);
        bool CheckCredentials(string username, string password);
    }
}