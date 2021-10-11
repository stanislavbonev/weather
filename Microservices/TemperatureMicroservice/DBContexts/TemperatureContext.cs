using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TemperatureMicroservice.Models;


namespace TemperatureMicroservice.DBContexts
{
    public class TemperatureContext : DbContext
    {
        public TemperatureContext(DbContextOptions<TemperatureContext> options) : base(options)
        {

        }
        public DbSet<Temperature> Temperatures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature>().HasData(
                new Temperature
                {
                    Id = 1,
                    Value = 1200,
                },
                new Temperature
                {
                    Id = 2,
                    Value = 569
                }
                );
        }
    }
}
