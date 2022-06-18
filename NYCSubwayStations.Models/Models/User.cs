using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Models.Models
{
    public class User
    {
        public User(string username, string name, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        private User() { }

        public string Username { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public IList<UserSubwayStation> Cities { get; private set; } = new List<UserSubwayStation>();
    }
}
