using ApplianceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceApp.Models

{
    public class WashingMachine : IAppliance
    {
         public string Brand { get; set; }
         public string Model { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Washing Machine - Brand: {Brand}, Model: {Model}");
        }
    }
}
