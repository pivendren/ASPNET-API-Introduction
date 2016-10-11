using Microsoft.Practices.Unity;
using Part1.ApplicationLogic.Interfaces;
using Part1.ApplicationLogic.Services;

namespace Part1.Common.Helpers
{
    public class DiContainerHelper
    {
        public static void RegisterComponents<T>(UnityContainer container) where T : LifetimeManager, new()
        {
            container.RegisterType<IValueService, ValueService>(new T());
        }
    }
}