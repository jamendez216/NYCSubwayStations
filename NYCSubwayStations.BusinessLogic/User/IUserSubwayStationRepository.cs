﻿using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.BusinessLogic.User
{
    public interface IUserSubwayStationRepository
    {
        public Task AddUserSubwayStation(UserSubwayStation userSubwayStation);
    }
}
