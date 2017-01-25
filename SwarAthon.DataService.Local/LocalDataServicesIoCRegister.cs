using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.DataServices;

namespace SwarAthon.DataService.Local
{
    public class LocalDataServicesIoCRegister
    {
        public static void Register()
        {
            IoC.Container.RegisterSingleton<ITestVersionLocalDataService, TestVersionLocalDataService>();
        }
    }
}
