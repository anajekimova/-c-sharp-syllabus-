using Microsoft.VisualStudio.TestPlatform.TestHost;
using Exercise8;
using System;
using Xunit;
using Program = Exercise8.Program;

namespace Arith.Exercise8.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expect = "You don`t need to  work so much!";
            var result = Program.CheckHours(73, 10);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test2()
        {
            var expect = "Your total salary is $378.75";
            var result = Program.CheckHours(47, 8.20);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test3()
        {
            var expect = "Your total salary is $262.5";
            var result = Program.CheckHours(35, 7.50);

            Assert.Equal(expect, result);
        }

    }
}
