using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                TestFactory();
            }

        }


        public static void TestFactory()
        {

            Console.WriteLine("Lets create a vehicle, then we can take it for a drive and replace its tires.\n");
            var vehicle = VehicleFactory.GetVehicle();
            Console.WriteLine("\n");
            vehicle.Drive();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n");
            vehicle.ReplaceTires();
            Console.WriteLine();
            Console.ReadKey();
        }


    }

}
