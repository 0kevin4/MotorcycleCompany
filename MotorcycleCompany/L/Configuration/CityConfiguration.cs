using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City
                {
                    Id = 1,
                    Name = "Guateque",
                    Province = "Boyaca",
                    Population = 1000
                },
                new City
                {
                    Id = 2,
                    Name = "Bogota",
                    Province = "Bogota.Dc",
                    Population = 10000
                }

           );
        }
    }
}
