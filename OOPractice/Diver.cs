using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Driver
    {
        private Vehicle vehicle;
        public Driver(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Drive()
        {
            return vehicle.SpeedUp();
        }
    }
}
