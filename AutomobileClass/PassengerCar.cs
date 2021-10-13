using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileClass
{
    class PassengerCar : Automobile
    {
        public int passengers { get; set; }
        public override double Range(double range, int passenger)
        {
            if (passenger <= 4 | passenger >= 0)
            {
                double actual_range = range - ((range / 100) * (6 * passenger));
                return Math.Round(actual_range, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
