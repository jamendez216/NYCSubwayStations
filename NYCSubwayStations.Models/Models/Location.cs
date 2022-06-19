using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Models.Models
{
    public class Location
    {
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        private Location(){ }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
