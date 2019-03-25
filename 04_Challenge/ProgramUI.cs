using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge
{
    class ProgramUI
    {
        BadgeRepository badgeRepository = new BadgeRepository();
        Badge badge = new Badge();
        Dictionary<int, List<string>> _access = new Dictionary<int, List<string>>();
        List<string> vs = new List<string>();

        public void Run()
        {
            Console.WriteLine("Welcome to the Komodo Badge Maintenance System");
            Console.WriteLine("How can we make your life better today?");

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please use 1-4 to select from the menu below: \n" +
                    "1. Create Badge\n" +
                    "2. Edit Badge\n" +
                    "3. View All Badges\n" +
                    "4. Exit");

                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        CreateABadge();
                        break;

                    case 2:
                        EditABadge();
                        break;

                    case 3:
                        ViewAllBadges();
                        break;

                    case 4:
                        isRunning = false;
                        break;
                }   
            }
        }

        private void CreateABadge()
        {
            List<string> doors = new List<string>();

            bool running = true;

            int ID = badgeRepository.CreateNewBadge();

            Console.Clear();
            Console.WriteLine($"New Badge created {ID}!!");

            while (running)
            {

                Console.WriteLine($"Which door would you like to add to badge {ID}?");
                string door = Console.ReadLine();

                doors.Add(door);

                Console.WriteLine("Would you like to add another door? (y/n)");
                string yn = Console.ReadLine().ToLower();

                if(yn == "n")
                {
                    running = false;
                }
            }

            bool succes = badgeRepository.AddBadgeToDic(ID, doors);

            if(succes == true)
            {
                Console.WriteLine("Doors successfully Added");
            }

            Console.WriteLine("Door not added");
        }

        private void EditABadge()
        {
            bool run = true;

            while (run) {
                Console.WriteLine("Please use 1-4 to select from the choices below: \n" +
                    "1. Add Door to Badge\n" +
                    "2. Remove Door from Badge\n" +
                    "3. Remove All Doors from a Badge\n" +
                    "4. Exit");


                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        AddDoorToBadge();
                        break;

                    case 2:
                        RemoveDoorFromBadge();
                        break;

                    case 3:
                        RemoveAllDoorsFromABadge();
                        break;

                    case 4:
                        run = false;
                        break;
                }

            }
        }

        private void RemoveAllDoorsFromABadge()
        { 

            Console.WriteLine("What Badge would you like to strip of all doors? ");

            int badge = int.Parse(Console.ReadLine());

            

            badgeRepository.RemoveAllDoorOnABadge(badge);
        }

        private void RemoveDoorFromBadge()
        {
            throw new NotImplementedException();
        }

        private void AddDoorToBadge()
        {
            throw new NotImplementedException();
        }

        private void ViewAllBadges()
        {
            Dictionary<int, List<string>> dictionary = badgeRepository.ListAllBadgers();

            List<string> first = new List<string>();

            _access = badgeRepository.ListAllBadgers();

           // if (_access.TryGetValue(, out bb))
           // {
           //     bb = stings;
           //     success = true;
           // };


        }
    }
}
