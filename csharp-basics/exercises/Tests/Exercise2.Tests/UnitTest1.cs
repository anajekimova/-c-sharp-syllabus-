using System;
using Xunit;

namespace Exercise2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expect = true;
            var result = Program.CheckEvenOrOdd(10);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test2()
        {
            var expect = false;
            var result = Program.CheckEvenOrOdd(5);

            Assert.Equal(expect, result);
        }
    }
}
