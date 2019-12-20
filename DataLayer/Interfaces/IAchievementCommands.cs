using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface IAchievementCommands
    {
        void UpdateAchievements(List<AchievementDTO> dtos);
        List<AchievementDTO> GetAchievements(int profileid);
    }
}
