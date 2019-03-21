using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge
{
    public class BadgeRepository
    {
        Badge myBadge = new Badge();
        Dictionary< int, List<string>> _access = new Dictionary< int, List<string>>();

        public int AddBadgeToDic(List<string> doors)
        {
            int count = _access.Count();
            int mybadge = count += 12350;
            Badge badge = new Badge(mybadge, doors);
            _access.Add(badge.MyBadge, badge.Doors);
            return mybadge;
        }

        public void RemoveDoorOnBadge(int badge, List<string> doors, string door)
        {
            List<string> vs = doors;

            string removedDoor = vs.Find(p => p.Contains(door));
            /*foreach(var rd in removedDoor)
            {
                doors.Remove(rd);
            }*/

            doors.Remove(removedDoor);

            doors = vs;

        }

        public string AddDoorOnBadge(int badge, List<string> doors, string door)
        {
            doors.Add(door);
            return door;
        }

        public List<string> RemoveAllDoorOnABadge(int badge, List<string> doors)
        {
            List<string> vs = new List<string>();
            doors = vs;

            return doors;

        }

        public Dictionary<int, List<string>> ListAllBadgers()
        {
            return _access;
        }

    }
}
