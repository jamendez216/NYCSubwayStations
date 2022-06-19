using NYCSubwayStations.BusinessLogic.User;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //Validate subwaystation exists

            var subwayStationExists = dbContext.SubwayStations.Any(x => x.Id == userSubwayStation.SubwayStationId);
            if (subwayStationExists)
            {
                dbContext.UserSubwayStations.AddAsync(userSubwayStation);
                return dbContext.SaveChangesAsync(); 
            }
            throw new Exception("Subway Station doesn't exists");
        }
    }
}
