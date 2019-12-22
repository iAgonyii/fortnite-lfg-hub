using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface IProfileContainerCommands
    {
        ProfileDTO GetProfileData(string input);
        List<ProfileDTO> GetProfiles();
    }
}
