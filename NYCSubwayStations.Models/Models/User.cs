using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Models.Models
{
    public class User
    {
        public User(string username, string password, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        private User() { }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }

        public IList<UserSubwayStation> Cities { get; private set; } = new List<UserSubwayStation>();
    }
}
