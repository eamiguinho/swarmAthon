using System.Collections.Generic;

namespace SwarmAthon.Core.Interfaces.Models
{
	public interface ITestVersion
	{
        int Id { get; set; }
		string Name { get; set; }
		string Alias { get; set; }
		List<ITestCase> TestCases { get; set; }
	}
}