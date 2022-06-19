﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NYCSubwayStations.API.RequestModels;
using NYCSubwayStations.BusinessLogic.User;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.Controllers
{
    [Authorize]
    public class UserSubwayStationsController : ApiController
    {
        private string username;
        private readonly IUserSubwayStationRepository repo;
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserSubwayStationsController(IUserSubwayStationRepository _repo, IHttpContextAccessor _httpContextAccessor)
        {
            httpContextAccessor = _httpContextAccessor;
            repo = _repo;
            username = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [HttpPost("AddUserSubwayStation")]
        public async Task<ActionResult> AddUserSubwayStation(AddUserSubwayStation userSubwayStation)
        {
            if (username != null)
            {
                await repo.AddUserSubwayStation(new UserSubwayStation(userSubwayStation.Username, userSubwayStation.SubwayStationId));
                return Ok();
            }
            return Unauthorized();
        }
        [HttpGet("GetUserFrequentlyStations")]
        public async Task<ActionResult> GetUserFrequentlyStations()
        {
            if (User != null)
            {
                var userStations = await repo.GetUserFrequentlyStations(username);
                return Ok(userStations);
            }
            return Unauthorized();
        }
    }
}
