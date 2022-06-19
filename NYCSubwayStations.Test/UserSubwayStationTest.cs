using NUnit.Framework;
using NYCSubwayStations.Database.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.Test
{
    public class UserSubwayStationTest : BaseTest
    {
        public static UserSubwayStationRepository repo = new UserSubwayStationRepository(context);
        [Test]
        public async Task GetUserSubwayStations()
        {
            var result = await repo.GetUserFrequentlyStations("jamendez");
            Assert.IsNotNull(result);
        }

    }
}
