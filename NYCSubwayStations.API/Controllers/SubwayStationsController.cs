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
    public class SubwayStationsController : ApiController
    {
        private readonly ISubwayStationRepository repo;
        public SubwayStationsController(ISubwayStationRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
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

    }
}
