using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Models.Models
{
    public class UserSubwayStation
    {
        public int Id { get; set; }
        public string UserId { get; private set; }
        public User User { get; private set; }
        public int SubwayStationId { get; set; }
        public SubwayStation SubwayStation { get; set; }
    }
}
