using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.Core.Interfaces.Services;

namespace SwarmAthon.Services.Implementation
{
	public class TestVersionService : ITestVersionService
	{
		readonly ITestVersionLocalDataService _localDataService;
		readonly ITestVersionOnlineDataService _onlineDataService;
	    private readonly IUserService _userService;

	    public TestVersionService(ITestVersionLocalDataService localDataService, ITestVersionOnlineDataService onlineDataService, IUserService userService)
		{
			_onlineDataService = onlineDataService;
	        _userService = userService;
	        _localDataService = localDataService;
		}

		public Task<DataResult<ITestVersion>> GetTestsForCurrentVersion()
		{
		    return Task.Run(() =>
		    {
		        var test = IoC.Container.GetInstance<ITestVersion>();
                var testCase = IoC.Container.GetInstance<ITestCase>();
		        testCase.Id = 1;
		        testCase.Title = "Test Order Flow";
                testCase.Steps = new List<string>{"Create Order on JustEat Website", "Confirm that appears on Orderpad", "Accept Order"};
                test.Id = 1;
		        test.Name = "Test Version 2.21";
                test.TestCases = new List<ITestCase>
                {
                    testCase
                };

		        return new DataResult<ITestVersion>(test);
		    });
		}

	    public void SubmitTest(ITestVersion currentTestVersion)
	    {
	        _onlineDataService.SubmitTest(currentTestVersion, _userService.GetCurrentUser());
	    }
	}
}
