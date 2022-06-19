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

        /*
        [HttpPost]
        public async Task<ActionResult> AddSubwayStations(List<SubwayStation> subwayStations)
        {
            CREATED METHOD TO DO THE INITIAL CHARGE OF ALL NYC SUBWAY STATIONS -SINCE THIS IS SOMETHING PRETTY MUCH STATIC, I COMMENTED THIS METHOD AFTER INSERTING ALL THE SUBWAY STATIONS

           await repo.AddSubwayStations(subwayStations);
            return Ok();
        }
        */
    }
}
