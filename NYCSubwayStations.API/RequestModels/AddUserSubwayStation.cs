using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.RequestModels
{
    public class AddUserSubwayStation
    {
        public string Username { get; private set; }
        public int SubwayStationId { get; set; }
    }
}
