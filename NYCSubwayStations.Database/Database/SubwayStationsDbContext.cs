using Microsoft.EntityFrameworkCore;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NYCSubwayStations.Database.Database
{
    public class SubwayStationsDbContext : DbContext
    {

        public SubwayStationsDbContext(DbContextOptions options) : base(options)
        {

        }
        public SubwayStationsDbContext(DbContextOptions<SubwayStationsDbContext> options) : base(options)
        {

        }

        public DbSet<SubwayStation> SubwayStations { get; set; }
        public DbSet<UserSubwayStation> UserSubwayStations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
