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
    public class SubwayStationRepository : ISubwayStationRepository
    {
        private readonly SubwayStationsDbContext dbContext;
        public SubwayStationRepository(SubwayStationsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Task AddSubwayStations(List<SubwayStation> subwayStations)
        {

            foreach (var item in subwayStations)
            {
                try
                {
                    dbContext.Add(item);
                }
                catch (Exception e)
                {
                    var itemerror = item.Id;
                    throw;
                }
            }
            return dbContext.SaveChangesAsync();
        }

        public async Task<List<SubwayStation>> GetAllSubwayStations()
        {
            return await dbContext.SubwayStations.ToListAsync();
        }
    }
}
