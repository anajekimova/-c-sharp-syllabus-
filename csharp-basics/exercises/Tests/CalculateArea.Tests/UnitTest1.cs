using System;
using Xunit;

namespace CalculateArea.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PosotiveRadius_NegativeNumsOfRadius_ExpectRadiusNeedBePosotive()
        {
            //Arrange
            var expect = "Radius must be positive.";

            //Act
            var result = Program.CalculateCircleArea(-6);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]

        public void PosotiveValue_InputNegativeValue_ExpectAllNumberNeedBePosotive()
        {
            //Arrange
            var expect = "Values must be positive";

            //Act
            var result = Program.CalculateRectangleArea(7, -4);

           //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void PosotiveValueOfTriagle_InputValue_ExpectTriagleValuaISPosotive()
        {
            //Arrange
            var expect = "Values must be positive";

            //Act
            var result = Program.CalculateTriangleArea(-6, 3);

            //Assert
            Assert.Equal(expect, result);
        }
    }
}
