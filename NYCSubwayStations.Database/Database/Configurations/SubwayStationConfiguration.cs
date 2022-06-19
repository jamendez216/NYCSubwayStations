using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Database.Database.Configurations
{
    public class SubwayStationConfiguration : IEntityTypeConfiguration<SubwayStation>
    {
        public void Configure(EntityTypeBuilder<SubwayStation> builder)
        {
            SubwayStationsList data = new SubwayStationsList();
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.HasIndex(e => new { e.Latitude, e.Longitude })
                .IsUnique();

            //builder.HasData(data.subwayStations);
        }
    }
}
