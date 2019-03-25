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

        public bool AddBadgeToDic(int ID, List<string> doors)
        {
            //int count = _access.Count();
            //int mybadge = count += 12350;
            Badge badge = new Badge(ID, doors);
            _access.Add(badge.MyBadge, badge.Doors);
            return true;

        }

        public int CreateNewBadge()
        {
            int count = _access.Count();
            int mybadge = count += 12350;
            return mybadge;

        }

        public void RemoveDoorOnBadge(int badge, List<string> doors, string door)
        {
            List<string> vs = doors;

            //string removedDoor = vs.Find(p => p.Contains(door));
            /*foreach(var rd in removedDoor)
            {
                doors.Remove(rd);
            }*/

            vs.RemoveAll(p => p.Contains(door));

            //doors.Remove(removedDoor);

            doors = vs;

        }

        public bool AddDoorOnBadge(int badge, List<string> doors, string door)
        {
            List<string> stings = new List<string>();

            List<string> bb = new List<string>();

            if (_access.TryGetValue(badge, out bb)) 
            {
                bb.AddRange(doors);
                return true;
            };

            return false;
        }

        public bool RemoveAllDoorOnABadge(int badge)
        {

            List<string> stings = new List<string>();

            List<string> bb = new List<string>();

            _access = ListAllBadgers();

            if (_access.TryGetValue(badge, out bb))
            {
                bb = stings;
                return true;
            };

            return false;
        }

        public Dictionary<int, List<string>> ListAllBadgers()
        {
            return _access;
        }

    }
}
