using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class Driver
    {
        public int ID { get; set; }
        public string DriverName { get; set; }
        public int OutOfLane { get; set; }
        public int Speeding { get; set; }
        public int RunStopSign { get; set; }
        public int Tailgate { get; set; }

        public Driver() { }
        public Driver(int id, string driverName, int outOfLane, int speeding, int runStopSign, int tailgate)
        {
            ID = id;
            DriverName = driverName;
            OutOfLane = outOfLane;
            Speeding = speeding;
            RunStopSign = runStopSign;
            Tailgate = tailgate;
        }
    }
}
