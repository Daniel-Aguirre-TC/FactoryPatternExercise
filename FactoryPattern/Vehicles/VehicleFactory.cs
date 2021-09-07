using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle()
        {
            Console.Clear();
            Console.WriteLine("Please enter how many wheels you'd like your new vehicle to have.\nPlease only enter 2, 4, or 8");
            var input = Console.ReadKey().KeyChar;
            int verifiedInput;
            if (int.TryParse(input.ToString(), out verifiedInput))
            {
                switch (verifiedInput)
                {
                    case 2:
                        return new Motorcycle();

                    case 4:
                        return new Car();

                    case 8:
                        return new BigRig();
                    default:
                        break;
                }
            }
            Console.WriteLine("\nInvalid Entry. Please Enter 2, 4, or 8.\nPress any key to return.\n");
            Console.ReadKey();
            Console.Clear();
            return GetVehicle();
        }


    }
}
