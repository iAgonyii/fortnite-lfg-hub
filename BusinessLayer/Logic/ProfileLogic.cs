using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Logic
{
    public class ProfileLogic
    {
        private IProfileCommands commands;
        public bool Login(string username, string password)
        {
            commands = new ProfileCommands();
            if (commands.CheckCredentials(new ProfileDTO() { Username = username, Password = password }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(string username, string password)
        {
            commands = new ProfileCommands();
            commands.RegisterNewProfile(new ProfileDTO() { Username = username, Password = password });
        }

        public void UpdateProfileInfo(int id, string freeText, string socialURL, bool looking, string picture, Regions region)
        {
            commands = new ProfileCommands();
            if(freeText == null)
            {
                freeText = "";
            }
            if(picture == null)
            {
                picture = "";
            }
            commands.UpdateProfileInfo(new ProfileDTO() { UserId = id, FreeText = freeText, SocialURL = socialURL, Looking = looking.ToString(), Picture = picture, Region = region.ToString() });
        }

        public int GetUserIdForName(string username)
        {
            commands = new ProfileCommands();
            int UserId = commands.GetUserIdForName(username);
            return UserId;
        }

        public string GetUsernameForId(int id)
        {
            commands = new ProfileCommands();
            string Username = commands.GetUsernameForId(id);
            return Username;
        }
    }
}
