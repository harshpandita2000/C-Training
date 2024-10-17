using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Make: {Make}, Model: {Model}");
        }

        public abstract double GetFuelEfficiency(); 
    }
}
