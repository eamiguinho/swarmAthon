using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Interfaces.Services
{
    public interface IUserService
    {
        void SetCurrentUser(IUser user);
        IUser GetCurrentUser();
    }
}