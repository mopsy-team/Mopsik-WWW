using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
