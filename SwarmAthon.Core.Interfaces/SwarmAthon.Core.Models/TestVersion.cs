using System;
using System.Collections.Generic;
using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Models
{
	public class TestVersion : ITestVersion
	{
		public string Alias { get; set; }

		public TestCaseState CurrentState { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public List<ITestCase> TestCases { get; set; }
		}
	}

