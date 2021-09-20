using GravityCalculator;
using System;
using Xunit;

namespace Arith.Exercise7.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Gravivety_GravityFallingTimeVelocityPositionNumbers_ExpectGravity()
        {
            //Arrange
            var expect = "-490.5";

            //Act
            var result = Program.CalculatedGravety(-9.81, 0, 0, 10);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void NumberPositive_GravityFallingTimeVelocityPositionNumbers_ExpectNumberIsPosotive()
        {
            //Arrange
            var expect = "All data must be positive";

            //Act
            var result = Program.CalculatedGravety(-9.81, 0, -5, 10);

            //Assert
            Assert.Equal(expect, result);
        }
    }
}
