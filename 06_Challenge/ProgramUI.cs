using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge
{
    class ProgramUI
    {
        VehicleRepository VehicleRepository = new VehicleRepository();
        List<Vehicle> vehicles = new List<Vehicle>();

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Green Revolution Database, brought to you by Komodo Engineering!");

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please use 1-6 to select from the Menu Below: ");
                Console.WriteLine(
                    "1. Create New Vehicle\n" +
                    "2. Update Existing Vehicle\n" +
                    "3. Delete Existing Vehicle\n" +
                    "4. View Details on Existing Vehicle\n" +
                    "5. View all vehicles on specified list\n" +
                    "6. Exit Application\n");

                int menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        CreateNewVehicle();
                        break;
                    case 2:
                        UpdateExistingVehicle();
                        break;
                    case 3:
                        DeleteExistingVehicle();
                        break;
                    case 4:
                        ViewDetailsOnExistingVehicle();
                        break;
                    case 5:
                        ViewAllVehiclesOnSpecifiedList();
                        break;
                    case 6:
                        isRunning = false;
                        break;
                }
            }
        }

        private void CreateNewVehicle()
        {
            Console.WriteLine("Please enter the Make of the Vehicle: ");
            string make = Console.ReadLine();

            Console.WriteLine("Please enter the Model of the Vehicle: ");
            string model = Console.ReadLine();

            Console.WriteLine("Please enter the Year of the Vehicle: ");
            int year = int.Parse(Console.ReadLine());

            /*Console.WriteLine("Please use 1 to 3 to select the proper Drive Type: \n" +
                "1. Electric\n" +
                "2. Hybrid\n" +
                "3. Gas\n");
            int driveChoice = int.Parse(Console.ReadLine());*/
            DriveType driveType = DriveTypeSelector();

            Console.WriteLine("Please enter Vehicle Mileage: ");
            int mileage = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Vehicle Cost: ");
            decimal cost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Vehicle Miles Driven: ");
            int milesDriven = int.Parse(Console.ReadLine());

            Console.WriteLine("How many Baby Seals have been made decease by this Vehicle: ");
            int babySeals = int.Parse(Console.ReadLine());
            
            int id = 12345 + VehicleRepository.ShowAllVehicles().Count;

            Vehicle vehicle = new Vehicle(id, make, model, year, driveType, mileage, cost, milesDriven, babySeals);

            VehicleRepository.AddVehicleToRepository(vehicle, driveType);

            Console.WriteLine("New Vehicle has been Added!!");
        }

        private void UpdateExistingVehicle()
        {
            DriveType driveType = DriveTypeSelector();

            PrintEachVehicle();

            Console.WriteLine("What would you like to update, select 1-4:" +
                "1. Mileage\n" +
                "2. Miles Driven\n" +
                "3. Vehicle Cost\n" +
                "4. Baby Seals Killed\n");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Please enter ID of record you would like to update: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter New Mileage: ");
                    int newMileage = int.Parse(Console.ReadLine());

                    VehicleRepository.UpdateVehicleMileageInRepository(id, driveType, newMileage);
                    break;

                case 2:
                    Console.WriteLine("Please enter ID of the record you would like to update: ");
                    int id3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter New Miles Driven: ");
                    int newMiles = int.Parse(Console.ReadLine());

                    VehicleRepository.UpdateVehicleMilesDriven(id3, driveType, newMiles);
                    break;

                case 3:
                    Console.WriteLine("Please enter ID of the record you would like to update: ");
                    int id2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter New Vehicle Cost: ");
                    int newCost = int.Parse(Console.ReadLine());

                    VehicleRepository.UpdateVehicleCost(id2, driveType, newCost);
                    break;

                case 4:

                    Console.WriteLine("Please enter ID of the record you would like to update: ");
                    int id4 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter New Miles Driven: ");
                    int newSeals = int.Parse(Console.ReadLine());

                    VehicleRepository.UpdateVehicleNumberOfBabySealsKilled(id4, driveType, newSeals);
                    break;
            }
        }



        private void DeleteExistingVehicle()
        {
            //DriveType driveType = DriveTypeSelector();

            PrintEachVehicle();

            List<Vehicle> _vehicles = VehicleRepository.ShowAllVehicles();

            Console.WriteLine("Please enter ID of vehicle you wish to remove: ");
            int result = int.Parse(Console.ReadLine());

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.ID == result)
                {
                    _vehicles.Remove(vehicle);
                    break;
                }
            }


        }

        private void ViewDetailsOnExistingVehicle()
        {
            //DriveType driveType = DriveTypeSelector();

            PrintEachVehicle();

            List<Vehicle> _vehicles = VehicleRepository.ShowAllVehicles();

            Console.WriteLine("Please enter ID of vehicle you wish to view: ");
            int result = int.Parse(Console.ReadLine());

            foreach(Vehicle vehicle in _vehicles)
            {
                if (vehicle.ID == result)
                {
                    Console.WriteLine(vehicle);
                    Console.ReadLine();
                }
            }
        }

        private void ViewAllVehiclesOnSpecifiedList()
        {
            DriveType driveType = DriveTypeSelector();

            PrintEachVehicle();

            Console.ReadLine();
        }

        private void PrintEachVehicle()
        {

            List<Vehicle> _vehicles = VehicleRepository.ShowAllVehicles();
            if (_vehicles.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No Vehicles in database");
            }

            foreach (Vehicle vehicle in _vehicles)
            {
                Console.WriteLine($"ID: {vehicle.ID}\nMake: {vehicle.Make}\nModel: {vehicle.Model} \nYear:{vehicle.Year} \nMileage: {vehicle.Mileage} \nMiles Driven: {vehicle.MilesDriven} \nSeals Killed:{vehicle.NumberOfBabySealsKilled}\n\n");
            }

        }
        private static DriveType DriveTypeSelector()
        {
            Console.WriteLine("Please use 1-3 to select drive type of vehicle you would like to update:\n" +
                            "1. Electric\n" +
                            "2. Gas\n" +
                            "3. Hybrid\n");

            int menuChoice = int.Parse(Console.ReadLine());

            DriveType driveType = new DriveType();
            switch (menuChoice)
            {
                case 1:
                    driveType = DriveType.ElectricDrive;
                    break;
                case 2:
                    driveType = DriveType.HybridDrive;
                    break;
                case 3:
                    driveType = DriveType.GasDrive;
                    break;
            }

            return driveType;
        }
    }
}
