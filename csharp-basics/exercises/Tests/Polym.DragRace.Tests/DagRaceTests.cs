using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polym.DragRace.Tests
{
    [TestClass]
    public class DagRaceTests
    {
        [TestMethod]
        public void FasterCar_RenaultCar_FastersCar()
        {
            var car = new Renault();
            var renault = "The faster car is Renault and car speed is 300";

            var actual = car.ShowCurrentSpeed();

            Assert.AreEqual(renault, actual);

        }
    }
}
