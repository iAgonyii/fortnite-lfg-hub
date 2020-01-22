using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerDTO
{
    public struct AchievementDTO
    {
        public int Rank { get; set; }
        public string EventId { get; set; }
        public string Event { get; set; }
        public string EventIconUrl { get; set; }
    }
}
