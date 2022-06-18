using Microsoft.AspNetCore.Mvc;
using NYCSubwayStations.API.RequestModels;
using NYCSubwayStations.BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ApiController
    {
        private readonly IUserRepository repo;
        public UserController(IUserRepository _repo)
        {
            repo = _repo;
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync(AddUserRequest user)
        {
            var emailExists = await repo.EMailExists(user.Email);
            if (!emailExists)
            {
                await repo.AddUserAsync(new Models.Models.User(user.Username, user.Password, user.Email));
                return Ok();
            }
            return BadRequest();
        }

    }
}
