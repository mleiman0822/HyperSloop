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

        public async Task<IEnumerable<User>> GetAllUserMetrics()
        {
            return await _applicationDbContext.Users.ToListAsync();
        }


    }
}
