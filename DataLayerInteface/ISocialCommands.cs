using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface ISocialCommands
    {
        void UpdateSocial(string url);
        string GetSocial(int profileid);
    }
}
