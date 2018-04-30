using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mopsik_www.Models
{
    public class SpacesUsage
    {
        
        public double Bus { get; set; }
        public double Car { get; set; }
        public double Truck { get; set; }

        private double GetPercentage(int available, int taken)
        {
            return ((double)taken / available) * 100;
        }

        public SpacesUsage(SpacesCount available, SpacesCount taken)
        {
            Bus = GetPercentage(available.Bus, taken.Bus);
            Car = GetPercentage(available.Car, taken.Car);
            Truck = GetPercentage(available.Truck, taken.Truck);
        }
    }
}
