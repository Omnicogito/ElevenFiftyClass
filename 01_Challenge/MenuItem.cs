using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuItem
    {
        public int ItemNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Cost { get; set; }

        public MenuItem() { }
        public MenuItem(int itemNumber, string mealName, string description, List<string> ingredients, decimal cost)
        {
            ItemNumber = itemNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Cost = cost;
        }
    }
}
