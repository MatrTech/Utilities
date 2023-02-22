using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matr.Utilities;
using FluentAssertions;

namespace Matr.Utilities.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly GenericFactory factory = new GenericFactory();

        // [ClassInitialize]
        // public static void ClassInit()
        // {

        // }

        // [ClassCleanup]
        // public static void ClassCleanup()
        // {

        // }

        [TestMethod]
        public void TestMethod1()
        {
            factory.RegisterOrReplace<ITestDependency>(new TestDependency());

            var testService = factory.Create<TestService>();

            testService.Should().NotBeNull();
        }

        // GetRegisteredServices
    }
}