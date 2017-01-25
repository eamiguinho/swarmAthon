using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;

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
