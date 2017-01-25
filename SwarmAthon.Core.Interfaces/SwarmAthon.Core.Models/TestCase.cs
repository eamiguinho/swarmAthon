using System;
using System.Collections.Generic;
using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Models
{
	public class TestCase : ITestCase
	{
		public int Id { get; set; }

		public List<string> Steps { get; set; }
	    public TestCaseState CurrentState { get; set; }

	    public string Title { get; set; }
	}
}

