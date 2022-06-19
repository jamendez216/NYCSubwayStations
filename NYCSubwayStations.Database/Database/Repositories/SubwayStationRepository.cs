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
                    throw e;
                }
            }
            return dbContext.SaveChangesAsync();
        }

        public async Task<List<SubwayStation>> GetAllSubwayStations()
        {
            return await dbContext.SubwayStations.ToListAsync();
        }

        public double GetDistanceBetweenStations(int fromStationId, int toStationId)
        {
            var fromStation = dbContext.SubwayStations.FirstOrDefault(x => x.Id == fromStationId);
            var toStation = dbContext.SubwayStations.FirstOrDefault(x => x.Id == toStationId);

            Location fromStationLocation = new Location(fromStation.Latitude, fromStation.Longitude);
            Location toStationLocation = new Location(toStation.Latitude, toStation.Longitude);

            return CalculateDistance(fromStationLocation, toStationLocation);

        }

        private double CalculateDistance(Location fromLocation, Location toLocation)
        {
            var d1 = fromLocation.Latitude * (Math.PI / 180.0);
            var num1 = fromLocation.Longitude * (Math.PI / 180.0);
            var d2 = toLocation.Latitude * (Math.PI / 180.0);
            var num2 = toLocation.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                     Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            var result = 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
            return result;
        }
    }
}
