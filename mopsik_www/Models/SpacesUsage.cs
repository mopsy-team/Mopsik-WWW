using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mopsik_www.Models
{
    public class SpacesUsage
    {
        
        public Usage Bus { get; set; }
        public Usage Car { get; set; }
        public Usage Truck { get; set; }

        public SpacesUsage(SpacesCount available, SpacesCount taken)
        {
            Bus = new Usage(available.Bus, taken.Bus);
            Car = new Usage(available.Car, taken.Car);
            Truck = new Usage(available.Truck, taken.Truck);
        }
    }
}
