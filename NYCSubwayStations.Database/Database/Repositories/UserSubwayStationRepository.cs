using NYCSubwayStations.BusinessLogic.User;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.Database.Database.Repositories
{
    public class UserSubwayStationRepository : IUserSubwayStationRepository
    {
        private readonly SubwayStationsDbContext dbContext;
        public UserSubwayStationRepository(SubwayStationsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task AddUserSubwayStation(UserSubwayStation userSubwayStation)
        {
            throw new NotImplementedException();
        }
    }
}
