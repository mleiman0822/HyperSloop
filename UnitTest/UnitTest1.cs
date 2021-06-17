using System;
using Xunit;
using HyperSloopApp.Models;
using HyperSloopApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTest1
{

    public class UnitTest1
    {
        public ApplicationDbContext ApplicationDbContext { get; set; }

        public ApplicationDbContext GetDbContext()
        {
            var cs = "Server=127.0.0.1;Port = 3306;Database=HyperSloop;Uid=root;Pwd=Password123;";
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseMySql(cs, ServerVersion.AutoDetect(cs))
              .Options;
            var DbContext = new ApplicationDbContext(options);
            return DbContext;
        }

        [Fact]
        public void SeedDataBaseWithDummyData()
        {
            //arrange
            var context = GetDbContext();
            var primaryLocation = new Location
            {
                Name = "BNG Corp",
            };
            context.Locations.Add(primaryLocation);

            var slideBlue = new Slide
            {
                HexColor = HexConverter(System.Drawing.Color.Blue),
                StartingFloor = 3,
                EndingFloor = 1,
                Location = primaryLocation,
                HeightInFeet = 30.4,
                LengthInFeet = 20.7,
            };
            context.Slides.Add(slideBlue);

            var slideGreen = new Slide
            {
                HexColor = HexConverter(System.Drawing.Color.Green),
                StartingFloor = 3,
                EndingFloor = 2,
                Location = primaryLocation,
                HeightInFeet = 20.6,
                LengthInFeet = 20.4,
            };
            context.Slides.Add(slideGreen);

            var slideOrange = new Slide
            {
                HexColor = HexConverter(System.Drawing.Color.Orange),
                StartingFloor = 2,
                EndingFloor = 1,
                Location = primaryLocation,
                HeightInFeet = 16.7,
                LengthInFeet = 28.4,
            };
            context.Slides.Add(slideOrange);

            var matthew = new User
            {
                Name = "Matthew Leiman",
                Email = "matthew.leiman@bngholdingsinc.com"
            };
            context.Users.Add(matthew);
               var john = new User
            {
                Name = "John Doge",
                Email = "DogCoinRules@gmail.com"
            };
            context.Users.Add(john);
            var Kenny = new User
            {
                Name = "Kenny Coin",
                Email = "BitCoinRules@gmail.com"
            };
            context.Users.Add(Kenny);
            var Susan = new User
            {
                Name = "Susan Taylor",
                Email = "IdontLikeCrypto@gmail.com"
            };
            context.Users.Add(Susan);
            var Ashley = new User
            {
                Name = "Ashley Davidson",
                Email = "ashvsdevildead@gmail.com"
            };
            context.Users.Add(Ashley);

            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1,9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = matthew,
                    Slide = slideBlue,
                    DateTime = userStartTime                  
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = matthew,
                    Slide = slideBlue,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = matthew,
                    Slide = slideBlue,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = matthew,
                    Slide = slideOrange,
                    DateTime = userStartTime
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = matthew,
                    Slide = slideOrange,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = matthew,
                    Slide = slideOrange,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = matthew,
                    Slide = slideGreen,
                    DateTime = userStartTime
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = matthew,
                    Slide = slideGreen,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = matthew,
                    Slide = slideGreen,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = john,
                    Slide = slideOrange,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = john,
                    Slide = slideOrange,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = john,
                    Slide = slideOrange,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = john,
                    Slide = slideBlue,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = john,
                    Slide = slideBlue,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = john,
                    Slide = slideBlue,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = john,
                    Slide = slideGreen,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = john,
                    Slide = slideGreen,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = john,
                    Slide = slideGreen,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Kenny,
                    Slide = slideGreen,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Kenny,
                    Slide = slideGreen,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Kenny,
                    Slide = slideGreen,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Kenny,
                    Slide = slideBlue,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Kenny,
                    Slide = slideBlue,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Kenny,
                    Slide = slideBlue,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Kenny,
                    Slide = slideOrange,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Kenny,
                    Slide = slideOrange,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Kenny,
                    Slide = slideOrange,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Susan,
                    Slide = slideOrange,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Susan,
                    Slide = slideOrange,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Susan,
                    Slide = slideOrange,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Susan,
                    Slide = slideGreen,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Susan,
                    Slide = slideGreen,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Susan,
                    Slide = slideGreen,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Susan,
                    Slide = slideBlue,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Susan,
                    Slide = slideBlue,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Susan,
                    Slide = slideBlue,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Ashley,
                    Slide = slideBlue,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Ashley,
                    Slide = slideBlue,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Ashley,
                    Slide = slideBlue,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Ashley,
                    Slide = slideOrange,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Ashley,
                    Slide = slideOrange,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Ashley,
                    Slide = slideOrange,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }
            for (int i = 0; i < 20; i++)
            {
                var userStartTime = DateTime.Now.AddDays(10 * i * -1);
                var slideStartTime = userStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var slideEndTime = slideStartTime.AddMilliseconds(new System.Random().Next(1, 9999));
                var userStartEvent = new Events
                {
                    EventType = EventType.UserStart,
                    User = Ashley,
                    Slide = slideGreen,
                    DateTime = userStartTime,
                };
                var slidestartevent = new Events
                {
                    EventType = EventType.SlideStart,
                    User = Ashley,
                    Slide = slideGreen,
                    DateTime = slideStartTime
                };
                var slideendevent = new Events
                {
                    EventType = EventType.SlideEnd,
                    User = Ashley,
                    Slide = slideGreen,
                    DateTime = slideEndTime
                };
                context.Events.Add(userStartEvent);
                context.Events.Add(slidestartevent);
                context.Events.Add(slideendevent);

            }


            //for (int i = 0; i < 20; i++)
            //{
            //    var slideEvent2 = new SlideEvent
            //    {
            //        User = john,
            //        Slide = slideGreen,
            //        StartTime = DateTime.Now.AddMinutes(new System.Random().Next(0, 500) * -1),
            //        Duration = new System.Random().Next(3, 20)
            //    };
            //    context.SlideEvents.Add(slideEvent2);
            //}

            //act

            context.SaveChanges();

            //assert
            var slideEvents1 = context.SlideEvents.Where(s => s.UserId == matthew.UserId)
                .Include(x => x.Slide).ToList();
            //Assert.True(slideEvents1.Count() == 60);
            //var slideEvents2 = context.SlideEvents.Where(s => s.UserId == john.UserId)
            //   .Include(x => x.Slide).ToList();
            //Assert.True(slideEvents2.Count() == 60);
            //var slideEvents3 = context.SlideEvents.Where(s => s.UserId == Kenny.UserId)
            //    .Include(x => x.Slide).ToList();
            //Assert.True(slideEvents3.Count() == 60);
            //var slideEvents4 = context.SlideEvents.Where(s => s.UserId == Susan.UserId)
            //   .Include(x => x.Slide).ToList();
            //Assert.True(slideEvents4.Count() == 60);
            //var slideEvents5 = context.SlideEvents.Where(s => s.UserId == Ashley.UserId)
            //   .Include(x => x.Slide).ToList();
            //Assert.True(slideEvents5.Count() == 60);

        }

        public void WipeDataBase()
        {

        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
