using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Models
{
    public class ModelsIoCRegister
    {
        public static void Register()
        {
            IoC.Container.Register<ITestCase, TestCase>();    
            IoC.Container.Register<ITestVersion, TestVersion>();
            IoC.Container.Register<IUser,User>();
        }
    }
}
