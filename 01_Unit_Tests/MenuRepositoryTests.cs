using System;
using System.Collections.Generic;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Unit_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void AddMenuItemShouldBeTrue()
        {
            MenuRepository menuRepository = new MenuRepository();

            MenuItem item1 = new MenuItem();
            MenuItem item2 = new MenuItem();
            MenuItem item3 = new MenuItem();

            menuRepository.AddMenuItemToList(item1);
            menuRepository.AddMenuItemToList(item2);
            menuRepository.AddMenuItemToList(item3);

            List<MenuItem> menuItems = menuRepository.RetrieveMenuList();

            int expected = 3;
            int actual = menuItems.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMenuItem()
        {
            MenuRepository menuRepository = new MenuRepository();
            List<string> blah = new List<string>();

            MenuItem item1 = new MenuItem();
            MenuItem item2 = new MenuItem();
            MenuItem item3 = new MenuItem(4, "pizza", "its pizza", blah, 4.53m);

            menuRepository.AddMenuItemToList(item1);
            menuRepository.AddMenuItemToList(item2);
            menuRepository.AddMenuItemToList(item3);

            menuRepository.RemoveProductBySpecifications(4);

            List<MenuItem> menuItems = menuRepository.RetrieveMenuList();

            int expected = 2;
            int actual = menuItems.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
