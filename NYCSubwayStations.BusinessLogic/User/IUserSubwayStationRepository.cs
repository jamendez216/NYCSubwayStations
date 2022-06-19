using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.BusinessLogic.User
{
    public interface IUserSubwayStationRepository
    {
        Task AddUserSubwayStation(UserSubwayStation userSubwayStation);
        Task<List<UserSubwayStation>> GetUserFrequentlyStations(string username);
    }
}
