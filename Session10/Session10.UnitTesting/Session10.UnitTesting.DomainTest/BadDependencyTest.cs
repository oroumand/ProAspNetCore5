using Session10.UnitTesting.Domain;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Session10.UnitTesting.DomainTest
{
    public class BadDependencyTest: IClassFixture<BadDependecyFixture>
    {

        BadDependency badDependency;
        public BadDependencyTest(ITestOutputHelper testOutputHelper, BadDependecyFixture badDependecyFixture)
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
