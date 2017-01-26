using System.Linq;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Factories;

namespace SwarmAthon.DataServices.Online.Dto
{
    public class TestVersionDtoFactory
    {
        public static ITestVersion Create(TestVersionDto dto)
        {
            var testVersion = IoC.Container.GetInstance<ITestVersion>();
            testVersion.Name = dto.Version;
            testVersion.TestCases = dto.Cases.Select(TestCaseDtoFactory.Create).ToList();
            return testVersion;
        }
    }
}