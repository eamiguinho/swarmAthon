using System;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.DataServices.Online.Dto;

namespace SwarmAthon.DataServices.Online.Factories
{
    public class TestCaseDtoFactory
    {
        public static CasesDto CreateDto(ITestCase testCase)
        {   
            var dto = new CasesDto();
            dto.Id = testCase.Id.ToString();
            dto.Result = testCase.CurrentState.ToString();
            dto.Steps = testCase.Steps;
            dto.Description = testCase.Title;
            return dto;
        }

        public static ITestCase Create(CasesDto dto)
        {
            var testCase = IoC.Container.GetInstance<ITestCase>();
            testCase.Id = dto.Id;
            testCase.Title = dto.Description;
            testCase.CurrentState = (TestCaseState)Enum.Parse(typeof(TestCaseState), dto.Result);
            testCase.Steps = dto.Steps;
            return testCase;
        }
    }
}