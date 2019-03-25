using System;
using System.Collections.Generic;
using _04_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        Badge myBadge = new Badge();
        Dictionary<int, List<string>> _access = new Dictionary<int, List<string>>();
        List<string> doors = new List<string>();
        BadgeRepository badgeRepo = new BadgeRepository();

        [TestMethod]
        public void AddBadgeShouldBeTrue()
        {
            Assert.IsTrue(badgeRepo.AddBadgeToDic(12350, doors));

        }
        [TestMethod]
        public void RemoveDoorShouldBeTrue()
        {
            doors.Add("B2");
            int badge1 = myBadge.MyBadge;
            string door = "B2";

            badgeRepo.RemoveDoorOnBadge(badge1, doors, door);

            int expected = 0;
            int actual = doors.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAllDoors()
        {
            int badge1 = badgeRepo.CreateNewBadge();
            string door1 = "A2";
            string door2 = "B2";
            doors.Add(door1);
            doors.Add(door2);
            badgeRepo.AddDoorOnBadge(badge1, doors, door1);
            badgeRepo.AddDoorOnBadge(badge1, doors, door2);

            Assert.IsTrue(badgeRepo.RemoveAllDoorOnABadge(badge1));
        }
    }
}
