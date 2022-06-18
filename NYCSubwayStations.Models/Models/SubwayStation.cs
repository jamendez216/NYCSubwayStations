using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Models.Models
{
    public class SubwayStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Line { get; set; }
        public string Notes { get; set; }
    }
}
