using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Interfaces.Services
{
	public interface ITestVersionService
	{
		Task<DataResult<ITestVersion>> GetTestsForCurrentVersion();
	    void SubmitTest(ITestVersion currentTestVersion);
	    void SetCurrentTestCase(ITestCase model);
	    ITestCase GetCurrentTestCase();
	}
}
