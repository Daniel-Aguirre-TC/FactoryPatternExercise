using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public int NumberOfTires { get; set; } = 2;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive()
        {
            Console.WriteLine("You put your helmet on and take your bike for a spin.");
        }

        public void ReplaceTires()
        {
            Console.WriteLine("You replace the two tires on your motorycle in twenty minutes.");
        }
    }
}