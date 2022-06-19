using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.RequestModels
{
    public class GetDistanceBetweenStationsRequest
    {
        public int FromStationId { get; set; }
        public int ToStationId { get; set; }
    }
}
