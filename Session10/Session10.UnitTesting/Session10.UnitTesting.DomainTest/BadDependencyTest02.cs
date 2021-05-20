using Session10.UnitTesting.Domain;
using Xunit;
using Xunit.Abstractions;

namespace Session10.UnitTesting.DomainTest
{
    [Collection("Group0203")]
    public class BadDependencyTest02 
    {

        BadDependency badDependency;
        public BadDependencyTest02(ITestOutputHelper testOutputHelper, BadDependecyFixture badDependecyFixture)
        {
            badDependency = badDependecyFixture.BadDependency;
            testOutputHelper.WriteLine(badDependency.Id);
        }

        [Fact]
        public void TestBadDependecy01()
        {
            Assert.True(badDependency.True());
        }
        [Fact]
        public void TestBadDependecy02()
        {
            Assert.True(badDependency.True());
        }
        [Fact]
        public void TestBadDependecy03()
        {
            Assert.True(badDependency.True());
        }
        [Fact]
        public void TestBadDependecy04()
        {
            Assert.True(badDependency.True());
        }
    }
}
