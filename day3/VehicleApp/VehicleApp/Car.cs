using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Car : Vehicle
    {
        public override double GetFuelEfficiency()
        {
            return 10.6; // Fuel efficiency in km/l
        }
    }
}
