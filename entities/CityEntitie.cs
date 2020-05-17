using System.Collections.Generic;

namespace WeatherApp.entities
{
    public class CityEntity
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public IList<string> TimeZone { get; set; }
    }
}