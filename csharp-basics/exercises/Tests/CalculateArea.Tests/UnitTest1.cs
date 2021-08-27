using System;
using Xunit;

namespace CalculateArea.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expect = "Radius must be positive.";
            var result = Program.CalculateCircleArea(-6);

            Assert.Equal(expect, result);
        }

        [Fact]

        public void Test2()
        {
            var expect = "Values must be positive";
            var result = Program.CalculateRectangleArea(7, -4);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test()
        {
            var expect = "Values must be positive";
            var result = Program.CalculateTriangleArea(-6, 3);

            Assert.Equal(expect, result);
        }
    }
}
