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
        private readonly IUserSubwayStationRepository repo;
        public SubwayStationsController(IUserSubwayStationRepository _repo)
        {
            repo = _repo;
        }

        [HttpPost]
        public async Task<ActionResult> AddUserSubwayStation(AddUserSubwayStation userSubwayStation)
        {
            //validate authentication

            if (true)//if valid
            {
                await repo.AddUserSubwayStation(new UserSubwayStation(userSubwayStation.Username, userSubwayStation.SubwayStationId));
                return Ok();
            }
            return Unauthorized();
        }
    }
}
