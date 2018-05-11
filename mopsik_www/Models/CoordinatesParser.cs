using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class CoordinatesParser
    {

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
    }
}
