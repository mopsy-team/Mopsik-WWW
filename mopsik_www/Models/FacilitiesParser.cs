using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class FacilitiesParser
    {
        [JsonProperty("monitoring")]
        public bool Monitoring { get; set; }
        [JsonProperty("garage")]
        public bool Garage { get; set; }
        [JsonProperty("toilets")]
        public bool Toilets { get; set; }
        [JsonProperty("petrol_station")]
        public bool PetrolStation { get; set; }
        [JsonProperty("dangerous_cargo_places")]
        public bool DangerousCargoPlaces { get; set; }
        [JsonProperty("fence")]
        public bool Fence { get; set; }
        [JsonProperty("restaurant")]
        public bool Restaurant { get; set; }
        [JsonProperty("sleeping_places")]
        public bool SleepingPlaces { get; set; }
        [JsonProperty("car_wash")]
        public bool CarWash { get; set; }
        [JsonProperty("lighting")]
        public bool Lighting { get; set; }
        [JsonProperty("security")]
        public bool Security { get; set; }
    }
}
