using System;
using System.Collections.Generic;
using _06_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Unit_Test
{
    [TestClass]
    public class VehicleRepositoryTest
    {
        [TestMethod]
        public void AddVehicleToRepositoryShouldBeTrue()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();

            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();
            Vehicle vehicle3 = new Vehicle();

            vehicleRepository.AddVehicleToRepository(vehicle1, DriveType.ElectricDrive);
            vehicleRepository.AddVehicleToRepository(vehicle2, DriveType.ElectricDrive);
            vehicleRepository.AddVehicleToRepository(vehicle3, DriveType.ElectricDrive);

            int expected = 3;
            int actual = vehicleRepository.ShowAllVehicles().Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateVehicleToRepositoryShouldBeTrue()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle(12345, "Honda", "Accord", 2013, DriveType.ElectricDrive, 32, 34000m, 324000, 2);

            vehicleRepository.AddVehicleToRepository(vehicle, DriveType.ElectricDrive);

            vehicleRepository.UpdateVehicleMileageInRepository(12345, DriveType.ElectricDrive, 45);

            vehicles = vehicleRepository.ShowAllVehicles();

            bool actual = vehicles.Exists(x => x.Mileage == 32);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void UpdateVehicleToRepositoryBabySealsKilled()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle(12345, "Honda", "Accord", 2013, DriveType.ElectricDrive, 32, 34000m, 324000, 2);

            vehicleRepository.AddVehicleToRepository(vehicle, DriveType.ElectricDrive);

            vehicleRepository.UpdateVehicleNumberOfBabySealsKilled(12345, DriveType.ElectricDrive, 0);

            vehicles = vehicleRepository.ShowAllVehicles();

            bool actual = vehicles.Exists(x => x.NumberOfBabySealsKilled == 2);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void UpdateVehicleToRepositoryMilesDriven()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle(12345, "Honda", "Accord", 2013, DriveType.ElectricDrive, 32, 34000m, 324000, 2);

            vehicleRepository.AddVehicleToRepository(vehicle, DriveType.ElectricDrive);

            vehicleRepository.UpdateVehicleMilesDriven(12345, DriveType.ElectricDrive, 455500);

            vehicles = vehicleRepository.ShowAllVehicles();

            bool actual = vehicles.Exists(x => x.MilesDriven == 324000);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void UpdateVehicleToRepositoryCost()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle(12345, "Honda", "Accord", 2013, DriveType.ElectricDrive, 32, 34000m, 324000, 2);

            vehicleRepository.AddVehicleToRepository(vehicle, DriveType.ElectricDrive);

            vehicleRepository.UpdateVehicleCost(12345, DriveType.ElectricDrive, 455500);

            vehicles = vehicleRepository.ShowAllVehicles();

            bool actual = vehicles.Exists(x => x.MilesDriven == 34000);

            Assert.IsFalse(actual);
        }
    }
}
