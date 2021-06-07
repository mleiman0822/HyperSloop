using System;
using Xunit;
using HyperSloopApp.Models;
using HyperSloopApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    
    public class UnitTest1
    {
        [Fact]
        public void GetAllTestData()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "HyperSloop")
                .Options;
               
            //inserting data into the database using one instance of the context.
            using(var context = new ApplicationDbContext(options))
            {
                context.Database.EnsureDeleted();
                
            }
            

            

            //Using a clean instance of the context to run the test 
            //using(var context = new ApplicationDbContext(options))
            //{
            //    HyperSloopService hyperSloopService = new HyperSloopService(context);
            //    IEnumerable<User> users = hyperSloopService.GetAll();

            //    Assert.Equal(1, users.Count());
            //}

        }
    }
}
