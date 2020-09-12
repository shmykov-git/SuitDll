using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suit;
using SuitDll.Tools;

namespace Test
{
    [TestClass]
    public class MyToolTests
    {
        [TestInitialize]
        public void Initialize()
        {
            IoC.Configure(IoCTest.Register);
        }

        [TestMethod]
        public void TestStart()
        {
            var tool = IoC.Get<MyTool>();
            var settings = IoC.Get<TestSettings>();

            tool.Start(settings.HelloMessage);
        }
    }
}
