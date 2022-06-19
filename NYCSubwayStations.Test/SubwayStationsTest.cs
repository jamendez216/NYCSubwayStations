using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NYCSubwayStations.Database.Database;
using NYCSubwayStations.Database.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.Test
{
    public class SubwayStationsTest : BaseTest
    {
        public static SubwayStationRepository repo = new SubwayStationRepository(context);

        [Test]
        public async Task GetAllSubwayStations()
        {
            var result = await repo.GetAllSubwayStations();
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetDistanceBetweenStationsTest()
        {
            var fromStationID = 1;
            var toStationID = 2;
            var result =  repo.GetDistanceBetweenStations(fromStationID, toStationID);
            Assert.IsNotNull(result);
        }
    }
}
