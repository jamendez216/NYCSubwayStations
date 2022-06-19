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
    public class UserSubwayStationsController : ApiController
    {
        private readonly IUserSubwayStationRepository repo;
        public UserSubwayStationsController(IUserSubwayStationRepository _repo)
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
        [HttpGet]
        public async Task<ActionResult> GetUserFrequentlyStations(string username)
        {
            //validate authentication

            if (true)//if valid
            {
                var userStations = await repo.GetUserFrequentlyStations(username);
                return Ok(userStations);
            }
            return Unauthorized();
        }
    }
}
