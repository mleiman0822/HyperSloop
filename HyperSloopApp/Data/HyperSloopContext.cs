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
        private readonly string connectionString;

        public HyperSloopContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet <Sensors> Sensors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
                //Move connection string to appsettings
                optionsBuilder.UseSqlServer(connectionString);         
        }
    }
}
