using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface IProfileCommands
    {
        ProfileDTO GetProfileData(string input);
        List<ProfileDTO> GetProfiles();
        void SaveNewProfile(ProfileDTO dto);
    }
}
