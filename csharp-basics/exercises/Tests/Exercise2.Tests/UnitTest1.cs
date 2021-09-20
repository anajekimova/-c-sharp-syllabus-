using System;
using Xunit;

namespace Exercise2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ISEven_ChekTheNUmber_ExpectNumberIsEven()
        {
            //Arrange
            var expect = true;

            //Act
            var result = Program.CheckEvenOrOdd(10);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void IsOdd_ChekNumber_ExpectIsOdd()
        {
            //Arrange
            var expect = false;
            
            //Act
            var result = Program.CheckEvenOrOdd(5);

            //Assert
            Assert.Equal(expect, result);
        }
    }
}
