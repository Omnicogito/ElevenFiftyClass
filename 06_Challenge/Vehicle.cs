using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge
{
    public enum DriveType { ElectricDrive, HybridDrive, GasDrive}

    public class Vehicle
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public DriveType Drive { get; set; }
        public int Mileage { get; set; }
        public decimal Cost { get; set; }
        public int MilesDriven { get; set; }
        public int NumberOfBabySealsKilled { get; set; }

        public Vehicle () { }
        public Vehicle (int id, string make, string model, int year, DriveType drive, int mileage, decimal cost, int milesDriven, int numberOfBabySealsKilled)
        {
            ID = id;
            Make = make;
            Model = model;
            Year = year;
            Drive = drive;
            Mileage = mileage;
            Cost = cost;
            MilesDriven = milesDriven;
            NumberOfBabySealsKilled = numberOfBabySealsKilled;
        }
    }
}
