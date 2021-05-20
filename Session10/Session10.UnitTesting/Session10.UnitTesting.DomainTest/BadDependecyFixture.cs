using Session10.UnitTesting.Domain;
using System;
using Xunit;

namespace Session10.UnitTesting.DomainTest
{
    public class BadDependecyFixture : IDisposable
    {
        public BadDependency BadDependency { get; set; }
        public BadDependecyFixture()
        {
            BadDependency = new BadDependency();
        }
        public void Dispose()
        {
           
        }
    }
    [CollectionDefinition("Group0203")]
    public class BadDependencyCollectionFixture: ICollectionFixture<BadDependecyFixture>
    {

    }
}
