using DataLayerDTO;

namespace DataLayerInterface
{
    public interface IProfileCommands
    {
        void UpdateProfileInfo(ProfileDTO dto);
        void RegisterNewProfile(ProfileDTO dto);
        bool CheckCredentials(ProfileDTO dto);
        int GetUserIdForName(string username);
    }
}
