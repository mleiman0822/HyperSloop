using HyperSloopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data
{
    public class HyperSloopContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserCard> UserCar { get; set; }

        public DbSet<Slide> Slides { get; set; }

        public DbSet <Sensors> Sensors { get; set; }

        public DbSet<Events> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Move connection string to appsettings
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=HyperSloop");
        }
    }
}
