using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class SpacesCount
    {

        [JsonProperty("bus")]
        public int Bus { get; set; }
        [JsonProperty("car")]
        public int Car { get; set; }
        [JsonProperty("truck")]
        public int Truck { get; set; }

        public SpacesCount(int bus, int car, int truck)
        {
            Bus = bus;
            Car = car;
            Truck = truck;
        }
    }
}
