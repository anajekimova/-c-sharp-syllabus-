using GravityCalculator;
using System;
using Xunit;

namespace Arith.Exercise7.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expect = "-490.5";
            var result = Program.CalculatedGravety(-9.81, 0, 0, 10);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test2()
        {
            var expect = "All data must be positive";
            var result = Program.CalculatedGravety(-9.81, 0, -5, 10);

            Assert.Equal(expect, result);
        }
    }
}
