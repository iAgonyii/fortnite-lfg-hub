using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Logic
{
    public class AchievementLogic
    {

        private readonly IAchievementCommands achievementCommands = new AchievementCommands();
        public void UpdateProfileAchievements(List<Achievement> achievements, int id)
        {
            List<AchievementDTO> dtos = achievementsToDtos(achievements);
            if (dtos.Count > 0)
            {
                achievementCommands.UpdateAchievements(dtos, id);
            }
        }

        private List<AchievementDTO> achievementsToDtos(List<Achievement> achievements)
        {
            List<AchievementDTO> dtos = new List<AchievementDTO>();
            foreach (Achievement achievement in achievements)
            {
                if (achievement.Rank != null && achievement.Event != Events._)
                {
                    dtos.Add(new AchievementDTO() { Rank = Convert.ToInt32(achievement.Rank), Event = achievement.Event.ToString() });
                }
            }
            return dtos;
        }

        public List<Achievement> DtosToAchievements(List<AchievementDTO> adtos)
        {
            List<Achievement> achvs = new List<Achievement>();
            foreach (AchievementDTO dto in adtos)
            {
                achvs.Add(new Achievement() { Rank = dto.Rank, Event = (Events)Enum.Parse(typeof(Events), dto.Event) });
            }
            return achvs;
        }
    }
}
