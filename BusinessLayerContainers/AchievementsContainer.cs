using BusinessLayer;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Achievement> orderedAchievements = achievements.OrderBy(a => a.Rank).ToList();
            return orderedAchievements;
        }
    

        public IDictionary<string, string> GetEvents()
        {
            IDictionary<string, string> events = new Dictionary<string, string>();
            events = aCommands.GetEvents();
            return events;
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
