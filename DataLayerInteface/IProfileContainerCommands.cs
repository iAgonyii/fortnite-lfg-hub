using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    interface IProfileContainerCommands
    {
        ProfileDTO GetProfileData(string input);
        List<ProfileDTO> GetProfiles();
    }
}
