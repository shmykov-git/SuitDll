using Suit;
using Suit.Logs;
using SuitDll.Tools;
using Unity;

namespace Test
{
	public static class IoCTest
	{
        public static void Register(UnityContainer container)
        {
            container.RegisterType<ILog, LogToDebugAndConsole>();

            container.RegisterSingleton<TestSettings>();
            container.RegisterFactory<IMyToolSettings>(c => IoC.Get<TestSettings>());
        }
    }
}