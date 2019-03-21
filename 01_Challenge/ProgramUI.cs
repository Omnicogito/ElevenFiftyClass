using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class ProgramUI
    {
        MenuRepository MenuRepository = new MenuRepository();
        List<MenuItem> menuItems = new List<MenuItem>();
        bool isRunning = true;

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to the Komodo Cafe Menu Database");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("How may we serve you today?");
            Console.ReadLine();

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please press 1-4 to select from the options below:\n" +
                    "1. Add New Menu Item\n" +
                    "2. Remove Menu Item\n" +
                    "3. View all Menu Items\n");

                int result = int.Parse(Console.ReadLine());

                MenuMenu(result);
            }
        }

        private void MenuMenu(int result)
        {
            switch (result)
            {
                case 1:
                    AddItemToMenu();
                    break;
                case 2:
                    RemoveItemFromList();
                    break;
                case 3:
                    ListAllTheMenuItems();
                    break;
                case 4:
                    isRunning = false;
                    break;

            }
        }


        private void AddItemToMenu()
        {
            Console.WriteLine("Please enter a new menu item #: ");
            int menuItem = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the name of the meal: ");
            string menuName = Console.ReadLine();

            Console.WriteLine("Please submit Menu Description: ");
            string description = Console.ReadLine();

            bool ingredientList = true;
            List<string> ingredients = new List<string>();

            Console.WriteLine("Please record first ingredient: ");

            while (ingredientList)
            {
                string ing = Console.ReadLine();
                ingredients.Add(ing);
                Console.WriteLine("Ingedient Added! Would you like to add another? (y/n)");
                if ("y" == Console.ReadLine())
                {
                    Console.WriteLine("Please enter next ingredient: ");
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    ingredientList = false;
                }
            }

            Console.WriteLine("Please enter cost for Meal: ");
            string result = Console.ReadLine();
            string costMeal = result.Replace("$", "");
            decimal costMealDec = decimal.Parse(costMeal);

            MenuItem menuItem1 = new MenuItem(menuItem, menuName, description, ingredients, costMealDec);

            MenuRepository.AddMenuItemToList(menuItem1);
        }

        private void RemoveItemFromList()
        {
            Console.Clear();
            ListAllTheMenuItems();

            Console.WriteLine("Please enter the Menu Number of the Menu Item: ");
            int menuNumber = int.Parse(Console.ReadLine());

            
            bool successful = MenuRepository.RemoveProductBySpecifications(menuNumber);

            if(successful == true)
            {
                Console.WriteLine("Item Successfully Removed");
            }
            else
            {
                Console.WriteLine("Errrror!!!!");
            }

            Console.ReadLine();
        }

        private void ListAllTheMenuItems()
        {
            menuItems = MenuRepository.RetrieveMenuList();

            //menuItems.ForEach(item => Console.WriteLine(item));
            foreach(MenuItem menuItem in menuItems)
            {
                Console.WriteLine($"Menu Number: \n{menuItem.ItemNumber}\nMenu Name: \n{menuItem.MealName}\nMenu Description: \n{menuItem.Description} \nIngredients: ");

                foreach(var ingredient in menuItem.Ingredients)
                {
                    Console.WriteLine(ingredient + "," + "\n");
                }

            }
            Console.ReadLine();
        }
    }
}
