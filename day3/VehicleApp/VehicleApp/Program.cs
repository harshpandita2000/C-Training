
namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car
            {
                Make = "Toyota",
                Model = "Fortuner"
            };

            
            Vehicle truck = new Truck
            {
                Make = "Ford",
                Model = "Ecosport"
            };

            car.DisplayInfo();
            Console.WriteLine($"Fuel Efficiency: {car.GetFuelEfficiency()} km/l\n");

        }
    }
}
