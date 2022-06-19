using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCSubwayStations.API.RequestModels
{
    public class AddUserRequest
    {
        public AddUserRequest(string username, string email, string password)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
