namespace mopsik_www.Models
{
    public class Coordinates
    {

        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string LongitudePrint { get; set; }
        public string LatitudePrint { get; set; }
        public string LongitudeString { get; set; }
        public string LatitudeString { get; set; }

        public Coordinates (double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
            LongitudePrint = longitude.ToString("n4").Replace(",", ".");
            LatitudePrint = latitude.ToString("n4").Replace(",", ".");
            LongitudeString = longitude.ToString().Replace(",", ".");
            LatitudeString = latitude.ToString().Replace(",", ".");
        }
    }
}
