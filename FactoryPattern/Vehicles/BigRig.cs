using System;
namespace FactoryPattern
{
    internal class BigRig : IVehicle
    {
        public int NumberOfTires { get; set; } = 8;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        

        public void Drive()
        {
            Console.WriteLine("You drive your Big Rig across country.");
        }

        public void ReplaceTires()
        {
            Console.WriteLine("Since you have so many tires you take your Big Rig\nto a mechanic who replaces your tires\nwithin 30 minutes.");
        }
    }
}