using HyperSloopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data
{
    public class HyperSloopService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HyperSloopService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }
       
        //getting the list of users slide event data
        public async Task<List<SlideEvent>> GetAllSlideEventDataAsync()
        {
            return await _applicationDbContext.SlideEvents.ToListAsync();
        }

        //inserting new slide event data into the database
        public async Task<bool> InsertSlideEventData(SlideEvent slideEvent)
        {
            await _applicationDbContext.SlideEvents.AddAsync(slideEvent);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //getting list of slideevent data by Id
        public async Task<SlideEvent> GetSlideEventDataByEmail(string email)
        {
            SlideEvent slideEvent = await _applicationDbContext.SlideEvents.FirstOrDefaultAsync
            (u => u.UserEmail.Equals(email));
            return slideEvent;
        }
    
     }

 }

