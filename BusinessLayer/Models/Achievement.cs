using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Achievement
    {
        public int? Rank { get; set; }
        public Events Event { get; set; }

        public Achievement(AchievementDTO dto)
        {
            Rank = dto.Rank;
            Event = (Events)Enum.Parse(typeof(Events), dto.Event);
        }
        public Achievement()
        {

        }
    }
}
