using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge
{
    public class VehicleRepository
    {
        Vehicle vehicle = new Vehicle();
        List<Vehicle> _electricVehicles = new List<Vehicle>();
        List<Vehicle> _gasVehicles = new List<Vehicle>();
        List<Vehicle> _hybridVeicles = new List<Vehicle>();

        public void AddVehicleToRepository(Vehicle vehicle, DriveType driveType)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    _electricVehicles.Add(vehicle);
                    break;

                case DriveType.GasDrive:
                    _gasVehicles.Add(vehicle);
                    break;

                case DriveType.HybridDrive:
                    _hybridVeicles.Add(vehicle);
                    break;
            }
        }

        public List<Vehicle> ShowAllVehicles()
        {
            /*switch (driveType)
            {
                case DriveType.ElectricDrive:
                    return _electricVehicles;

                case DriveType.GasDrive:
                    return _gasVehicles;

                case DriveType.HybridDrive:
                    return _hybridVeicles;

                default:
                    return _electricVehicles;
            }*/


            List<Vehicle> vehicle = new List<Vehicle>();
            _electricVehicles.AddRange(_gasVehicles);
            _electricVehicles.AddRange(_hybridVeicles);
            vehicle = _electricVehicles;

            return vehicle;


        }

        public List<Vehicle> ShowAllVehiclesOfAType(DriveType driveType)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    return _electricVehicles;

                case DriveType.GasDrive:
                    return _gasVehicles;

                case DriveType.HybridDrive:
                    return _hybridVeicles;

                default:
                    return _electricVehicles;
            }
        }

        public bool DeleteVehicle(DriveType driveType, string make, string model, int milesDriven)
        {
            bool complete = false;

            switch (driveType)
            {

                case DriveType.ElectricDrive:
                    var vehicles = _electricVehicles.Single(p => p.Make == make && p.Model == model && p.MilesDriven == milesDriven);

                    _electricVehicles.Remove(vehicles);
                    complete = true;
                    return complete;

                case DriveType.GasDrive:
                    var vehicles2 = _gasVehicles.Single(p => p.Make == make && p.Model == model && p.MilesDriven == milesDriven);

                    _gasVehicles.Remove(vehicles2);
                    complete = true;
                    return complete;

                case DriveType.HybridDrive:
                    var vehicles3 = _hybridVeicles.Single(p => p.Make == make && p.Model == model && p.MilesDriven == milesDriven);

                    _hybridVeicles.Remove(vehicles3);

                    complete = true;
                    return complete;

                default:
                    complete = false;
                    return complete;

            }
        }

        public void UpdateVehicleMileageInRepository(int id, DriveType driveType, int newMileage)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    /*var dict = _electricVehicles.ToDictionary(x => x.ID);
                    Vehicle found;
                    if (dict.TryGetValue(mileage, out found)) found.Mileage = newMileage;
                    break;*/

                    var thing = _electricVehicles.Find(p => p.ID == id);
                    thing.Mileage = newMileage;
                    break;

                case DriveType.GasDrive:
                    /*var dict2 = _gasVehicles.ToDictionary(x => x.ID);
                    Vehicle found2;
                    if (dict2.TryGetValue(mileage, out found2)) found2.Mileage = newMileage;*/

                    var thing2 = _gasVehicles.Find(p => p.ID == id);
                    thing2.Mileage = newMileage;

                    break;

                case DriveType.HybridDrive:
                    /*var dict3 = _hybridVeicles.ToDictionary(x => x.Mileage);
                    Vehicle found3;
                    if (dict3.TryGetValue(mileage, out found3)) found3.Mileage = newMileage;*/

                    var thing3 = _hybridVeicles.Find(p => p.ID == id);
                    thing3.Mileage = newMileage;

                    break;

            }
        }
        public void UpdateVehicleNumberOfBabySealsKilled(int id, DriveType driveType, int newNumber)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    var thing1 = _electricVehicles.Find(p => p.ID == id);
                    thing1.NumberOfBabySealsKilled = newNumber;
                    break;

                case DriveType.GasDrive:
                    var thing2 = _gasVehicles.Find(p => p.ID == id);
                    thing2.NumberOfBabySealsKilled = newNumber;
                    break;

                case DriveType.HybridDrive:
                    var thing3 = _hybridVeicles.Find(p => p.ID == id);
                    thing3.NumberOfBabySealsKilled = newNumber;
                    break;
            }
        }
        public void UpdateVehicleMilesDriven(int id, DriveType driveType, int newMilesDriven)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    var thing1 = _electricVehicles.Find(p => p.ID == id);
                    thing1.MilesDriven = newMilesDriven;
                    break;

                case DriveType.GasDrive:
                    var thing2 = _gasVehicles.Find(p => p.ID == id);
                    thing2.MilesDriven = newMilesDriven;
                    break;

                case DriveType.HybridDrive:
                    var thing3 = _hybridVeicles.Find(p => p.ID == id);
                    thing3.MilesDriven = newMilesDriven;
                    break;
            }
        }
        public void UpdateVehicleCost(int id, DriveType driveType, decimal newCost)
        {
            switch (driveType)
            {
                case DriveType.ElectricDrive:
                    var thing1 = _electricVehicles.Find(p => p.ID == id);
                    thing1.Cost = newCost;
                    break;

                case DriveType.GasDrive:
                    var thing2 = _gasVehicles.Find(p => p.ID == id);
                    thing2.Cost = newCost;
                    break;

                case DriveType.HybridDrive:
                    var thing3 = _hybridVeicles.Find(p => p.ID == id);
                    thing3.Cost = newCost;
                    break;
            }
        }

    }
}
