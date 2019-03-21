using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class DriverRepository
    {
        Driver Driver = new Driver();
        List<Driver> drivers = new List<Driver>();

        public void AddNewDriverToSystem(Driver driver)
        {
            drivers.Add(driver);
        }

        public decimal CalculateDriverDebt(Driver driver)
        {
            decimal result = 50m;

            result += (driver.OutOfLane * 5) + (driver.RunStopSign * 8) + (driver.Speeding * 2) + (driver.Tailgate * 70);

            return result;
        }

        public List<Driver> ReturnListOfDrivers()
        {
            return drivers;
        }
    }
}
