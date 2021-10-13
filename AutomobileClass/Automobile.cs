using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileClass
{
    class Automobile
    {
        public string TypeTM { get; set; }
        public double AvgFuel { get; set; }
        public int TankSize { get; set; }
        public double Speed { get; set; }

        public double TankRange(int fuelLevel) {
            double range = (fuelLevel / this.AvgFuel) * 100;
            return Math.Round(range, 2);
        }

        public virtual double Range(double range, int pass_or_cargo)
        {
            double actual_range = range;
            return actual_range;
        }

        public double HoursPerDistance (int fuelLevel, double distance)
        {
            double hours = 0;
            if (TankRange(fuelLevel) >= distance)
            {
                hours = distance / this.Speed;
                return hours;
            }
            else
            {
                return -1;
            }
        }

    }
}
