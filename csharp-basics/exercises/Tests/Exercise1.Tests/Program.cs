using System;
using Xunit;

namespace Exercise1.Tests
{
    public class TestClass
    {
        [Fact]
        public void Test1()
        {
            var expect = true;
            var result = Program.CheckNumber(10, 5);
            Assert.Equal(expect, result);
        }

        [Fact]

        public void Test2()
        {
            var expect = true;
            var result = Program.CheckNumber(20, 5);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test3()
        {
            var expect = true;
            var result = Program.CheckNumber(15, 5);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test4()
        {
            var expect = true;
            var result = Program.CheckNumber(5, 15);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test5()
        {
            var expect = true;
            var result = Program.CheckNumber(15, 30);
            Assert.Equal(expect, result);
        }
    }
}
