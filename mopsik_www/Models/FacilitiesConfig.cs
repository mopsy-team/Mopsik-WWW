using System.Collections.Generic;

namespace mopsik_www.Models
{
    public class FacilitiesConfig
    {
        public Dictionary<string, Facility> Facilities = new Dictionary<string, Facility>()
            {
                { "monitoring", new Facility("Monitoring", "videocam") },
                { "garage", new Facility("Warsztat", "build") },
                { "toilets", new Facility("Toalety", "wc") },
                { "petrol_station", new Facility("Stacja benzynowa", "local_gas_station") },
                { "dangerous_cargo_places", new Facility("Miejsce dla pojazdów z ładunkiem niebezpiecznym", "warning") },
                { "sleeping_places", new Facility("Miejsca noclegowe", "hotel") },
                { "restaurant", new Facility("Gastronomia", "restaurant") },
                { "car_wash", new Facility("Myjnia samochodowa", "local_car_wash") },
                { "security", new Facility("Ochrona", "security") },
                { "lighting", new Facility("Oświetlenie", "lightbulb_outline") },
            };
    }
}
