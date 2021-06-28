using HyperSloopApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperSloopApp.Data;
using HyperSloopApp.Models;
using HyperSloopApp.Data;
using Microsoft.AspNetCore.Http;
using HyperSloopApp.Services;

namespace HyperSloopApp.Data
{
    public class HyperSloopService
    {
        private ApplicationDbContext _applicationDbContext;       
        public string Email { get; set; }

        private IServiceProvider services;
        private DbContextOptions<ApplicationDbContext> dbOptions;

        public HyperSloopService(ApplicationDbContext applicationDbContext, UDPService udpService, IServiceProvider services, DbContextOptions<ApplicationDbContext> dbOptions)
        {
            this.services = services;
            this.dbOptions = dbOptions;
            _applicationDbContext = applicationDbContext;
        }
  
        //getting the list of users slide event data
        public IQueryable<SlideEvent> GetUserSlideEvents()
        {
            return _applicationDbContext.SlideEvents.Include(x => x.User)
                .Include(x => x.Slide).ToList().AsQueryable();
        }

        public IQueryable<Slide> GetSlides()
        {
            return _applicationDbContext.Slides;
        }

        //getting list of slide event data by email
        public async Task<IQueryable<SlideEvent>> GetSlideEventsDataByUserId(string email)
        {
            var slideEvent =  _applicationDbContext.SlideEvents.Where(x => x.User.Email == email).Include(x => x.Slide).AsQueryable();
            return slideEvent;

        }

        public async Task<IQueryable<SlideEvent>> GetComparedUserEventsByName(string name)
        {
            var slideEvent = _applicationDbContext.SlideEvents.Where(x => x.User.Name == name).Include(x => x.Slide).Include(x => x.User).AsQueryable();
            return slideEvent;
        }

        public void UserEventInsert(int slideid, string email)
        {

                var user = _applicationDbContext.Users.Where(x => x.Email == email).First();
                _applicationDbContext.Events.Add(new Events
                {
                    DateTime = DateTime.Now,
                    EventType = EventType.UserStart,
                    User = user,
                    UserId = user.UserId,
                    SlideId = slideid,
                    Slide = _applicationDbContext.Slides.Where(x => x.SlideId == slideid).First()
                });
            
            _applicationDbContext.SaveChanges();
        }

    }

 }

