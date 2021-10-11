using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PressureMicroservice.Models;


namespace PressureMicroservice.DBContexts
{
    public class PressureContext : DbContext
    {
        public PressureContext(DbContextOptions<PressureContext> options) : base(options)
        {

        }
        public DbSet<Pressure> Pressures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pressure>().HasData(
                new Pressure
                {
                    Id = 1,
                    Value = 1200,
                },
                new Pressure
                {
                    Id = 2,
                    Value = 569
                }
                );
        }
    }
}
