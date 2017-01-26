using System.Linq;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.Core.Interfaces.Services;

namespace SwarmAthon.Services.Implementation.Tests
{
	public class TestVersionService : ITestVersionService
	{
		readonly ITestVersionLocalDataService _localDataService;
		readonly ITestVersionOnlineDataService _onlineDataService;
	    private readonly IUserService _userService;
	    private ITestCase _currentTestCase;

	    public TestVersionService(ITestVersionLocalDataService localDataService, ITestVersionOnlineDataService onlineDataService, IUserService userService)
		{
			_onlineDataService = onlineDataService;
	        _userService = userService;
	        _localDataService = localDataService;
		}

		public async Task<DataResult<ITestVersion>> GetTestsForCurrentVersion()
		{
		    var test = await _onlineDataService.GetCurrenTestVersion();
		    return test;
		}

	    public void SubmitTest(ITestVersion currentTestVersion)
	    {
            currentTestVersion.TestCases.First().CurrentState = TestCaseState.Passed;
            currentTestVersion.TestCases[1].CurrentState = TestCaseState.Failed;
            currentTestVersion.TestCases[2].CurrentState = TestCaseState.Failed;
            _onlineDataService.SubmitTest(currentTestVersion, _userService.GetCurrentUser());
	    }

	    public void SetCurrentTestCase(ITestCase model)
	    {
	        _currentTestCase = model;
	    }

	    public ITestCase GetCurrentTestCase()
	    {
	        return _currentTestCase;
	    }
	}
}
