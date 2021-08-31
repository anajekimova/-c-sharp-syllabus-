using System;
using Xunit;

namespace Exercise6.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expect = "Loza";
            var result = Program.ColoLoza(10);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test2()
        {
            var expect = "Coza";
            var result = Program.ColoLoza(9);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test3()
        {
            var expect = "Woza";
            var result = Program.ColoLoza(14);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test4()
        {
            var expect = "CozaLoza";
            var result = Program.ColoLoza(15);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test65()
        {
            var expect = "29";
            var result = Program.ColoLoza(29);

            Assert.Equal(expect, result);
        }       
    }
}
