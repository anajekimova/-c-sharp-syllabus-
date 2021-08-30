using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuppeteerSharp.Input;

namespace Polym.Hierarchy.Tests
{
    [TestClass]
    public class HierarchyTests
    {
        [TestMethod]
        public void Mouse_MakeSound_ReturnMakeSound()
        {
            var mouse = new Mouse("Mouse", 3, "mammal", "Europa");
            var sound = "Pi pi pi ";

            var actual = mouse.MakeSound();

            Assert.Equals(sound, actual);
        }

        [TestMethod]
        public void Zebra_ZebraEat_ReturnEat()
        {
            var meat = new Meat(2);
            var zebra = new Zebra("Mammal", "Zebra", 127, "Africa");
            var expect = "Zebra are not eating that type of food!";

            var actual = zebra.Eat(meat);

            Assert.Equals(expect, actual);
        }

        [TestMethod]
        public void Tiger_TigerPrinOut_ReturnPrintOut()
        {
            var tiger = new Tiger("Felime", "Tiger", 130, "Africa");
            string expected = "Felime [Tiger, 130, Africa, 0]";
           
            var actual = tiger.ToString();

            Assert.Equals(expected, actual);
        }
    }
}
