using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface ISocialCommands
    {
        void UpdateSocial(string url);
        string GetSocial(int profileid);
    }
}
