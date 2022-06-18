using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Database.Database.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Username);
            builder.Property(e => e.Username)
                .ValueGeneratedNever();

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.HasMany<UserSubwayStation>()
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
