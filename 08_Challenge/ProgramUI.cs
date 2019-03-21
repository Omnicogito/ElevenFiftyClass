using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    class ProgramUI
    {
        DriverRepository _driverRepository = new DriverRepository();
        List<Driver> drivers = new List<Driver>();

        public void Run()
        {
            Console.WriteLine("Welcome to Komodo Insurance Risk Assessor");
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please use the number to select from below options:\n" +
                    "1. Add New Drive\n" +
                    "2. Calculate Premium\n" +
                    "3. Exit\n");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        AddNewDriver();
                        break;
                    case 2:
                        CalculatePremium();
                        break;
                    case 3:
                        isRunning = false;
                        break;
                }
            }
        }

        private void CalculatePremium()
        {
            drivers = _driverRepository.ReturnListOfDrivers();
            Driver driver = new Driver();

            if (drivers.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No Drivers yet added");
            }

            foreach (Driver vehicle in drivers)
            {
                Console.WriteLine($"Driver ID: {vehicle.ID}\nDriver Name: {vehicle.DriverName}\nOut of Lanes: {vehicle.OutOfLane}\nRan Stop Signs: {vehicle.RunStopSign} \nSpeeding:{vehicle.Speeding} \nTailgating Events: {vehicle.Tailgate}\n");
            }

            Console.WriteLine("Please enter name of diver you would like to calculate the premium of: ");
            string name = Console.ReadLine();

            var selected = drivers.Single(p => p.DriverName == name);

            decimal cost = _driverRepository.CalculateDriverDebt(selected);

            Console.WriteLine($"{selected.DriverName} your monthy premium is {cost.ToString("C2")}");
            Console.ReadLine();
        }

        private void AddNewDriver()
        {
            Console.WriteLine("Please enter Driver's Full Name: ");
            string driverName = Console.ReadLine();

            Console.WriteLine("Please enter the number of times vehicle has wandered out of its lane: ");
            int outOfLane = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of times driver has exceeded the posted speed limit: ");
            int speeding = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of stop signs ran by the Driver: ");
            int runStopSign = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of time the drvier has tailgated another vehicle: ");
            int tailgating = int.Parse(Console.ReadLine());

            int id = 12345 + _driverRepository.ReturnListOfDrivers().Count;

            Driver driver = new Driver(id, driverName, outOfLane, speeding, runStopSign, tailgating);

            _driverRepository.AddNewDriverToSystem(driver);

            Console.WriteLine("Driver Added!");
            Console.ReadLine();
        }
    }
}
