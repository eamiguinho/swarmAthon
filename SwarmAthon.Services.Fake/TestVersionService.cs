using System;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Models;
using SwarmAthon.Core.Interfaces.Services;

namespace SwarmAthon.Services.Fake
{
	public class TestVersionService : ITestVersionService
	{
		public Task<DataResult<ITestVersion>> GetTestsForCurrentVersion()
		{
		    return Task.Run(() =>
		    {
		        var test = 
		    });
		}
	}
}
