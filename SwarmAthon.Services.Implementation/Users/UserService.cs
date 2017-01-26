using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.Core.Interfaces.Services;

namespace SwarmAthon.Services.Implementation.Users
{
    public class UserService : IUserService
    {
        private IUser _user;

        public void SetCurrentUser(IUser user)
        {
            _user = user;
        }

        public IUser GetCurrentUser()
        {
            return _user;
        }
    }
}
