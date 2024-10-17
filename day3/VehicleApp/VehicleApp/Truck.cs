using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Truck : Vehicle
    {
        public override double GetFuelEfficiency()
        {
            return 6.4; // Fuel efficiency in km/l
        }
    }
}
