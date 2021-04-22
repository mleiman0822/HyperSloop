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
    }
}
