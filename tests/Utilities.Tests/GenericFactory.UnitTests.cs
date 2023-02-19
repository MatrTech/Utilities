using Matr.Utilities;

namespace Matr.Utilities.Tests;

[TestClass]
public class UnitTest1
{
    protected readonly GenericFactory factory = new GenericFactory();

    [ClassInitialize]
    public static void ClassInit()
    {

    }

    [ClassCleanup]
    public static void ClassCleanup()
    {

    }

    [TestMethod]
    public void TestMethod1()
    {
        // factory.RegisterOrReplace(new Mock<ITestDependency>().Object);
    }

    // GetRegisteredServices
}