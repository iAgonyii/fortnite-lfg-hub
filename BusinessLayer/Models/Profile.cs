using BusinessLayer.Logic;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Profile
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FreeText { get; set; }
        public string SocialURL { get; set; }
        public bool Looking { get; set; }
        public string Picture { get; set; }
        public Regions Region { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Flairs> Flairs { get; set; }

        public Profile(ProfileDTO dto)
        {
            this.UserId = dto.UserId;
            this.Username = dto.Username;
            this.FreeText = dto.FreeText;
            this.SocialURL = dto.SocialURL;
            if (!string.IsNullOrWhiteSpace(dto.Looking))
            {
                this.Looking = bool.Parse(dto.Looking);
            }
            this.Picture = dto.Picture;
            if (!string.IsNullOrWhiteSpace(dto.Region))
            {
                this.Region = (Regions)Enum.Parse(typeof(Regions), dto.Region);
            }
            this.Achievements = DtosToAchievements(dto.achievementDTOs);
            this.Comments = DtosToComments(dto.commentDTOs);
            this.Flairs = DtoFlairsToFlairs(dto.Flairs);
        }




        // Converting dtos to business models
        private List<Achievement> DtosToAchievements(List<AchievementDTO> dtos)
        {
            List<Achievement> achvs = new List<Achievement>();
            foreach (AchievementDTO dto in dtos)
            {
                achvs.Add(new Achievement() { Rank = dto.Rank, Event = (Events)Enum.Parse(typeof(Events), dto.Event) });
            }
            return achvs;
        }

        
        private List<Comment> DtosToComments(List<CommentDTO> dtos)
        {
            List<Comment> comments = new List<Comment>();
            foreach (CommentDTO dto in dtos)
            {
                Comment comment = new Comment(dto);
                comments.Add(comment);
            }
            return comments;
        }

        private List<Flairs> DtoFlairsToFlairs(List<string> dtoflairs)
        {
            List<Flairs> flairs = new List<Flairs>();
            if (dtoflairs.Count > 0)
            {
                foreach (string flair in dtoflairs)
                {
                    flairs.Add((Flairs)Enum.Parse(typeof(Flairs), flair));
                }
            }
            return flairs;
        }
    }
}
