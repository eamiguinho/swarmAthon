using System.Linq;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Dto;

namespace SwarmAthon.DataServices.Online.Factories
{
    public class VersionSubmitDtoFactory
    {
        public static VersionSubmitDto Create(ITestVersion currentTestVersion, IUser currentUser)
        {
            var dto = new VersionSubmitDto();
            dto.User = UserDtoFactory.Create(currentUser);
            dto.Cases = currentTestVersion.TestCases.Select(TestCaseDtoFactory.CreateDto).ToList();
            return dto;
        }   
    }
}