using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NYCSubwayStations.API.RequestModels;
using NYCSubwayStations.BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository repo;
        private readonly IConfiguration config;
        
        public UserController(IUserRepository _repo, IConfiguration _config)
        {
            repo = _repo;
            config = _config;
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult> AddUserAsync(AddUserRequest user)
        {
            var emailExists = await repo.EMailExists(user.Email);
            var userExists = await repo.UsernameExists(user.Username);
            if (!emailExists && !userExists)
            {
                await repo.AddUserAsync(new Models.Models.User(user.Username, user.Password, user.Email));
                return Ok();
            }
            return BadRequest("Email or Username already in use.");
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginRequest credentials)
        {
            var user = await repo.GetUserFromCredentials(credentials.email, credentials.password);
            if (user != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim(ClaimTypes.Email, user.Email)
                };
                var token = GenerateToken(claims);
                return Ok(token);
            }
            return BadRequest("User not found");
        }

        private string GenerateToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                config["Jwt:Issuer"],
                config["Jwt:Issuer"],
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds,
                claims: claims);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
