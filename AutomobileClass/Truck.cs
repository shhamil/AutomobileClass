using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileClass
{
    class Truck : Automobile
    {
        public int LoadCapacityKg { get; set; }
        public override double Range(double range, int cargoKg)
        {
            if (cargoKg <= this.LoadCapacityKg | cargoKg >= 0)
            {
                double actual_range = range - ((range / 100) * (0.02 * cargoKg));
                return Math.Round(actual_range, 2);
            }
            else
            {
                return -1;
            }
        }
    }

}
