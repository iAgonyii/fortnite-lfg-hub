using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    public interface ISocialCommands
    {
        void UpdateSocial(int profileid, string url);
        string GetSocial(int profileid);
    }
}
