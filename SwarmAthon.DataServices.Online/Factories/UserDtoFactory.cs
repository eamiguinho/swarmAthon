using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Dto;

namespace SwarmAthon.DataServices.Online.Factories
{
    public class UserDtoFactory
    {
        public static UserDto Create(IUser user)
        {
            var dto = new UserDto();
            dto.Id = user.Id.ToString();
            dto.Name = user.Name;
            return dto;
        }
    }
}