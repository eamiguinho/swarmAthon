using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;
using SwarmAthon.DataServices.Online.Tests;

namespace SwarmAthon.DataServices.Online
{
    public class OnlineDataServicesIoCRegister
    {
        public static void Register()
        {
            IoC.Container.RegisterSingleton<ITestVersionOnlineDataService, TestVersionOnlineDataService>();
        }
    }
}
