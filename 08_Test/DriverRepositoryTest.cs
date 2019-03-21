using System;
using System.Collections.Generic;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Test
{
    [TestClass]
    public class DriverRepositoryTest
    {
        [TestMethod]
        public void AddDriverToRepository()
        {
            DriverRepository driverRepository = new DriverRepository();
            Driver driver = new Driver();
            List<Driver> drivers = new List<Driver>();

            driverRepository.AddNewDriverToSystem(driver);

            int expected = 1;
            int actual = driverRepository.ReturnListOfDrivers().Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCostShouldBeTrue()
        {
            DriverRepository driverRepository = new DriverRepository();

            Driver driver = new Driver(1, 1, 1, 1);

            decimal expected = 135m;

            decimal actual = driverRepository.CalculateDriverDebt(driver);

            Assert.AreEqual(expected, actual);

        }
    }
}
