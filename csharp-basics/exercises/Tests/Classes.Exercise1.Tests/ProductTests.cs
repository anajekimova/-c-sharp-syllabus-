using Exercise1;
using System;
using Xunit;

namespace Classes.Exercise1.Tests
{
    public class ProductTests
    {
        [Fact]
        public void PrintProduct_MousePrice_MousePriceInfo()
        {
            var mouse = "Logitech mouse, 70 EUR, 14 units.";
            var expect = new Product("Logitech mouse", (double) 70, 14);

            var actual = mouse.PrintPrice();

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void MouseChenge_MousePriceAfterChage()
        {
            var mouse = "Logitech mouse, 70 EUR, 14 units.";
            var expect = new Product("Logitech mouse", 70, 8);

            var actual = mouse.PrintPrice();

            Assert.Equal(expect, actual);
        }
    }
}
