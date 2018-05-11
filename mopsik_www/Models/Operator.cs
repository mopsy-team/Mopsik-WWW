using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class Operator
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
