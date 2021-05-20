using Session10.UnitTesting.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Session10.UnitTesting.DomainTest
{
    public class AssertTypes
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public AssertTypes(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertTrue()
        {
            Assert.True(true);
        }

        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertFalse()
        {
            Assert.False(false);
        }
        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertStrings()
        {
            string str1 = "abcd";
            string str2 = "ab";
            string str3 = "bc";
            string str4 = "abcd";
            string str5 = "cd";
            Assert.Equal(str1, str4);
            _testOutputHelper.WriteLine("Assert Equal Done");
            Assert.StartsWith(str2, str1);
            _testOutputHelper.WriteLine("Assert StartsWith Done");
            Assert.EndsWith(str5, str1);
            _testOutputHelper.WriteLine("Assert EndsWith Done");
            Assert.Contains(str3, str1);
            _testOutputHelper.WriteLine("Assert Contains Done");
            //Assert.Matches
        }


        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertNumbers()
        {
            var int1 = 123;
            var int2 = 123;
            var int3 = 22;
            var int4 = 100;
            var int5 = 1000;
            Assert.Equal(int1, int2);
            Assert.NotEqual(int1, int3);
            Assert.InRange(int1, int4, int5);
            Assert.NotInRange(int3, int4, int5);

        }


        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertObjects()
        {
            Product nullProduct = null;
            Product notNullProduct = new Product();
            object product = new Product();
            
            var store = new Store();
            var sameStore = store;

            var notSameStore = new Store();

            Assert.Null(nullProduct);
            Assert.NotNull(notNullProduct);
            Assert.IsType<Product>(product);
            //Assert.IsNotType
            Assert.IsAssignableFrom<IStore>(store);


            Assert.Same(store, sameStore);
            Assert.NotSame(store, notSameStore);
        }

        [Fact]
        [Trait("Maktab", "Classic")]
        public void AssertCollections()
        {
            //Assert.Contains()
            //Assert.DoesNotContain();
            //Assert.Equal
            //Assert.All
        }

        [Fact(Skip ="Product owner disabled it")]
        [Trait("Maktab", "Classic")]
        public void AssertException()
        {
            var stringHelper = new StringHelper();
            Assert.Throws<Exception>(() => stringHelper.ToInt("fgh"));
        }
    }
}
