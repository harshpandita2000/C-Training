﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceApp.Interfaces
{
    public interface IAppliance
    {
         string Brand { get; set; }
         string Model { get; set; }
        void DisplayDetails();
    }
}
