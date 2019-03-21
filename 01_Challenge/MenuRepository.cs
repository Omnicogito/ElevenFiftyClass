using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    {
        MenuItem MenuItem = new MenuItem();
        List<MenuItem> menuItems = new List<MenuItem>();

        public void AddMenuItemToList(MenuItem item)
        {
            menuItems.Add(item);
        }

        public List<MenuItem> RetrieveMenuList()
        {
            return menuItems;
        }

        public bool RemoveProductBySpecifications(int menuNumber)
        {
            var removeItem = menuItems.Single(p => p.ItemNumber == menuNumber);

            menuItems.Remove(removeItem);

            return true;
                
            /*foreach (MenuItem menu in menuItems)
            {
                if ()
                {
                    _productList.Remove(product);
                    return true;
                }

            }
            return false;*/
        }
        
    }
}
