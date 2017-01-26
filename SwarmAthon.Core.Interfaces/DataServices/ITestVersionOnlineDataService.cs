using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Interfaces.DataServices
{
	public interface ITestVersionOnlineDataService
	{
	    Task SaveTestVersion(ITestVersion testVersion, IUser user);
        Task<DataResult<ITestVersion>> GetCurrenTestVersion();
        Task<DataResult<bool>> SubmitTest(ITestVersion currentTestVersion, IUser getCurrentUser);
	}
}