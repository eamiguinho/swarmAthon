using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Dto;

namespace SwarmAthon.DataServices.Online.Factories
{
    public class TestCaseDtoFactory
    {
        public static CasesDto Create(ITestCase testCase)
        {   
            var dto = new CasesDto();
            dto.Id = testCase.Id.ToString();
            dto.Result = testCase.CurrentState.ToString();
            return dto;
        }
    }
}