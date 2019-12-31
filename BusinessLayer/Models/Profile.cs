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
        public List<Flairs> Flairs { get; set; }

        public List<Achievement> Achievements { get; set; }
        public List<Comment> Comments { get; set; }
        

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
            this.Flairs = DtoFlairsToFlairs(dto.Flairs);
        }




        // Converting dtos to business models

        private List<Flairs> DtoFlairsToFlairs(List<string> dtoflairs)
        {
            List<Flairs> flairs = new List<Flairs>();

                foreach (string flair in dtoflairs)
                {
                    flairs.Add((Flairs)Enum.Parse(typeof(Flairs), flair));
                }
            return flairs;
        }
    }
}
