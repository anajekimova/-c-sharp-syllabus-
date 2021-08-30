using Exercise5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Exercise5.Tests
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void PrintDate_WriteDate_DateTests()
        {
            var result = new Date(25, 4, 2021);
            var expect = "25 / 4 / 2021" ;

            var actual = result.PrintDays();

            Assert.AreEqual(expect, actual);
        }
    }
}
