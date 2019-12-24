using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    public interface IAchievementCommands
    {
        void UpdateAchievements(List<AchievementDTO> dtos, int profileid);
        List<AchievementDTO> GetAchievements(int profileid);
    }
}
