using ApplianceApp.Models;
using ApplianceApp.Interfaces;

namespace ApplianceApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            IAppliance washingMachine = new WashingMachine
            {
                Brand = "Whirlpool",
                Model = "WH2000R"
            };

            IAppliance refrigerator = new Refrigerator
            {
                Brand = "LG",
                Model = "LG2000R"
            };

            washingMachine.DisplayDetails();
            refrigerator.DisplayDetails();
        }
    }
}
