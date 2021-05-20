using Session10.UnitTesting.Domain;
using System;
using Xunit;

namespace Session10.UnitTesting.DomainTest
{
    public class StringHelperTest
    {
        [Fact]
        [Trait("Maktab", "London")]
        public void IsNumber_Return_True_When_PassStringNumber()
        {
            var stringHelper = new StringHelper();

            var result = stringHelper.IsNumber("12345");

            Assert.True(result);
        }

        [Fact]
        [Trait("Maktab", "London")]
        public void IsNumber_Return_False_When_PassInvalidStringNumber()
        {
            var stringHelper = new StringHelper();
            var result = stringHelper.IsNumber("ABCD");
            Assert.True(result);
        }


        [Fact]
        [Trait("Maktab", "London")]
        public void ToInt_Return_MyNumber_When_PassStringNumber()
        {
            var stringHelper = new StringHelper();

            var result = stringHelper.ToInt("12345");

            Assert.Equal(12345, result);
        }


    }
}
