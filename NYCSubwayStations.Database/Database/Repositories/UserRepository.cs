using Microsoft.EntityFrameworkCore;
using NYCSubwayStations.BusinessLogic.User;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.Database.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SubwayStationsDbContext dbContext;
        public UserRepository(SubwayStationsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Task AddUserAsync(User user)
        {
            dbContext.Add(user);
            return dbContext.SaveChangesAsync();
        }

        public Task<bool> EMailExists(string email)
        {
            return dbContext.Users.Where(x => x.Email == email).AnyAsync();
        }

        public Task<bool> UsernameExists(string username)
        {
            return dbContext.Users.Where(x => x.Username == username).AnyAsync();
        }

        public Task<User> GetUserFromCredentials(string email, string password)
        {
            return dbContext.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefaultAsync();
        }
    }
}
