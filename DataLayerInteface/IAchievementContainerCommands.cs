using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    public interface IAchievementContainerCommands
    {
        List<AchievementDTO> GetAchievements(int profileid);
    }
}
