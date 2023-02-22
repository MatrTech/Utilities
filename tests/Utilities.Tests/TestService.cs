namespace Matr.Utilities.Tests
{
    public class TestService
    {
        private ITestDependency dependency;

        public TestService(ITestDependency dependency)
        {
            this.dependency = dependency;
        }
    }
}