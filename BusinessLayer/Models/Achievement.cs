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
        public string EventId { get; set; }
        public string Event { get; set; }
        public string EventIconUrl { get; set; }

        public Achievement(AchievementDTO dto)
        {
            Rank = dto.Rank;
            EventId = dto.EventId;
            Event = dto.Event;
            EventIconUrl = dto.EventIconUrl;
        }
        public Achievement()
        {

        }
    }
}
