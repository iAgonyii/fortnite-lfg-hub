using BusinessLayer;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayerContainer
{
    public class AchievementsContainer
    {
        public List<Achievement> achievements;
        private readonly IAchievementContainerCommands aCommands = new AchievementCommands();

        public List<Achievement> GetAchievementsForProfile(int profileid)
        {
            achievements = new List<Achievement>();

            List<AchievementDTO> dtos = aCommands.GetAchievements(profileid);
            achievements = DtosToAchievements(dtos);

            return achievements;
        }

        private List<Achievement> DtosToAchievements(List<AchievementDTO> dtos)
        {
            List<Achievement> achvs = new List<Achievement>();
            foreach (AchievementDTO dto in dtos)
            {
                achvs.Add(new Achievement(dto));
            }
            return achvs;
        }
    }
}
