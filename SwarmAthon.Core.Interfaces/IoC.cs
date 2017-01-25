using SimpleInjector;

namespace SwarmAthon.Core.Interfaces
{
    public class IoC
    {
        private static Container _container;
        public static Container Container { get { return _container ?? (_container = new Container()); } }
    }
}
