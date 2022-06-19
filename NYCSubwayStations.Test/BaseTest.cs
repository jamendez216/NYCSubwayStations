using Microsoft.EntityFrameworkCore;
using NYCSubwayStations.Database.Database;
using NYCSubwayStations.Database.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Test
{
    public class BaseTest
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NYCSubwayStations;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static DbContextOptionsBuilder builder = new DbContextOptionsBuilder<SubwayStationsDbContext>().UseSqlServer(connectionString);
        public static SubwayStationsDbContext context = new SubwayStationsDbContext(builder.Options);
    }
}
