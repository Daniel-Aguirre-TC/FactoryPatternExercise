using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public int NumberOfTires { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive();
        public void ReplaceTires();

    }
}
