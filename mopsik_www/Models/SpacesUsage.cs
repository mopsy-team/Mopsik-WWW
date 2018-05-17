using System;
using System.Collections.Generic;

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

        public Dictionary<String, Usage> ToDict()
        {
            return new Dictionary<String, Usage>()
            {
                {"car", Car },
                {"bus", Bus },
                {"truck", Truck }
            };
        }
    }
}
