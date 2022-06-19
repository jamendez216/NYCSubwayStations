using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NYCSubwayStations.API.RequestModels;
using NYCSubwayStations.BusinessLogic.User;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.Controllers
{
    [Authorize]
    public class SubwayStationsController : ApiController
    {
        private readonly ISubwayStationRepository repo;
        public SubwayStationsController(ISubwayStationRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet("GetNYCSubwayStations")]
        public async Task<ActionResult> GetNYCSubwayStations()
        {
            //Check authentication
            if (true)
            {
                var subwayStations = await repo.GetAllSubwayStations();
                return Ok(subwayStations);
            }
            return Unauthorized();
        }

        [HttpPost("GetDistanceBetweenStations")]
        public ActionResult GetDistanceBetweenStations(GetDistanceBetweenStationsRequest stationsId)
        {
            //Check authentication
            if (true)
            {
                var distanceBetweenStations = repo.GetDistanceBetweenStations(stationsId.FromStationId, stationsId.ToStationId);
                return Ok(distanceBetweenStations + " Meters");
            }
            return Unauthorized();
        }


    }
}
