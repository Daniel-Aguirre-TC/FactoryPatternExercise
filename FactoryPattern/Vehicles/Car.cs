using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Car : IVehicle
    {
        public int NumberOfTires { get; set; } = 4;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive()
        {
            Console.WriteLine("You take your car for a drive.");
        }

        public void ReplaceTires()
        {
            Console.WriteLine("Since you have four tires and each takes 10 minutes, it takes\nyou a total of 40 minutes to replace your tires.");
        }
    }
}
