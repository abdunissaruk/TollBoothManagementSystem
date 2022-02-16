using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothManagementSystem.Model
{
    internal class VehicleDetails
    {
        public string VehicleReg { get; set; }

        public DateTime VehicleDateTime { get; set; }

        public string TripType { get; set; }

        public string VehicleClass { get; set; }

        public int Amount { get; set; }

    }
}
