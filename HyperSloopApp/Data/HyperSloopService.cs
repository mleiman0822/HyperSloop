using HyperSloopApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperSloopApp.Data;
using HyperSloopApp.Models;
using HyperSloopApp.Data;
using Microsoft.AspNetCore.Http;

namespace HyperSloopApp.Data
{
    public class HyperSloopService
    {
        //[Inject]
        //HttpContextAccessor httpContext { get; set; }

        private readonly ApplicationDbContext _applicationDbContext;       
        public string Email { get; set; }

        public HyperSloopService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        //public HyperSloopService(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email)) throw new Exception("Email must not be blank");
        //    Email = email;
        //}

        //getting the list of users slide event data
        public IQueryable<SlideEvent> GetUserSlideEvents()
        {
            return _applicationDbContext.SlideEvents.Include(x => x.User)
                .Include(x => x.Slide).ToList().AsQueryable();
        }

        //inserting new slide event data into the database
        public async Task<bool> InsertSlideEventData(SlideEvent slideEvent)
        {
            await _applicationDbContext.SlideEvents.AddAsync(slideEvent);
            await _applicationDbContext.SaveChangesAsync();
            return true;
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

    }

 }

