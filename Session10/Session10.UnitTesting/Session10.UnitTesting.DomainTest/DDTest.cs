using Session10.UnitTesting.Domain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace Session10.UnitTesting.DomainTest
{
    public class DDTest
    {
        [Fact]
        public void Sum01()
        {
            var input1 = 1;
            var input2 = 2;
            var expectedResult = 3;
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void Sum02()
        {
            var input1 = 2;
            var input2 = 3;
            var expectedResult = 5;
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void Sum03()
        {
            var input1 = 3;
            var input2 = 5;
            var expectedResult = 8;
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 5, 8)]
        public void Sum04(int input1,int input2, int expectedResult)
        {
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [MemberData("GetData", MemberType = typeof(DDTest))]
        public void Sum05(int input1, int input2, int expectedResult)
        {
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [MemberData("GetData",MemberType = typeof(DDTest))]

        public void Sum06(int input1, int input2, int expectedResult)
        {
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [MyData]

        public void Sum07(int input1, int input2, int expectedResult)
        {
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [MyData]

        public void Sum08(int input1, int input2, int expectedResult)
        {
            var calc = new Calc();

            var actualResult = calc.Sum(input1, input2);


            Assert.Equal(expectedResult, actualResult);
        }
        public static List<object[]> GetData()
        {
            return new List<object[]>
            {
                new object[]{ 1, 2, 3 },
                new object[]{ 2, 3, 5 },
                new object[]{ 3, 5, 8 }
            };
        }
    }

    public class MyDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return new List<object[]>
            {
                new object[]{ 1, 2, 3 },
                new object[]{ 2, 3, 5 },
                new object[]{ 3, 5, 8 }
            };
        }
    }
}
