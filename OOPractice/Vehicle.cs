using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Vehicle
    {
        private string vehicleName;
        private string vehicleSpeed;
        public Vehicle(string name, string speed)
        {
            vehicleName = name;
            vehicleSpeed = speed;
        }

        public string SpeedUp()
        {
            return $"{vehicleName}: speed up {vehicleSpeed}";
        }
    }
}
