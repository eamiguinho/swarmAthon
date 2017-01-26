using System;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Services;
using SwarmAthon.Services.Implementation.Tests;
using SwarmAthon.Services.Implementation.Users;

namespace SwarmAthon.Services.Implementation
{
	public class ServicesIoCRegister
	{
		public static void Register() {
		   IoC.Container.RegisterSingleton<ITestVersionService, TestVersionService>();
            IoC.Container.RegisterSingleton<IUserService, UserService>();
        }
	}
}
