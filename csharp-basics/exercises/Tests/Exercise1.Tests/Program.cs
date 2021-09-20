using System;
using Xunit;

namespace Exercise1.Tests
{
    public class TestClass
    {
        [Fact]
        public void NumberSum_ChekNumber_ExpectSumIsFifteen()
        {
            var expect = true;
            var result = Program.CheckNumber(10, 5);
            Assert.Equal(expect, result);
        }

        [Fact]

        public void Test2()
        {
            //Arrange
            var expect = true;

            //Act
            var result = Program.CheckNumber(20, 5);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void IsFifteen_ChekNumber_ExpectFirstNumberIsFifteen()
        {
            var expect = true;
            var result = Program.CheckNumber(15, 5);
            Assert.Equal(expect, result);
        }

        [Fact]        
        public void Fifteen_ChekNumber_ExpectSecondtNumberIsFifteen()
        {
            var expect = true;
            var result = Program.CheckNumber(5, 15);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Differnce_ChekNumber_ExpectDifferceIsFifteen()
        {
            var expect = true;
            var result = Program.CheckNumber(15, 30);
            Assert.Equal(expect, result);
        }
    }
}
