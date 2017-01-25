﻿using System.Collections.Generic;

namespace SwarmAthon.Core.Interfaces.Models
{
	public interface ITestCase
	{
		int Id { get; set; }
		string Title { get; set; }
		List<string> Steps { get; set; }
        TestCaseState CurrentState { get; set; }

    }
}