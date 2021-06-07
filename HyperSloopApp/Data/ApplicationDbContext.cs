using HyperSloopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Location> Location { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SlideEvent> SlideEvents { get; set; }
        public DbSet<User> Users { get; set; }

        //public DbSet<ScanEvent> ScanEvents { get; set; }
        //public DbSet<Sensor> Sensors { get; set; }
        //public DbSet<SensorEvent> SensorEvents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
