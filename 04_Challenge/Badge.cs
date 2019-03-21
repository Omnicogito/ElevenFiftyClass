using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge
{
    public class Badge
    {
        public int MyBadge { get; set; }
        public List<string> Doors { get; set; }

        public Badge () { }
        public Badge(int myBadge, List<string> doors)
        {
            MyBadge = myBadge;
            Doors = doors;
        }
    }
}
