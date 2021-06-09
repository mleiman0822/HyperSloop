using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperSloopApp.Models;

namespace HyperSloopApp.Data
{
    public class AppService
    {
        public AppService(HyperSloopService hyperSloopService)
        {
            _HyperSloopService = hyperSloopService;
        }
        public HyperSloopService _HyperSloopService { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Returns the bool for the email. If the email already exists. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool Instantiate(string email)  
        {
            if (!string.IsNullOrEmpty(Email)) return true;
            Email = email;
            return true;
        }

        //public async Task<IEnumerable<SlideEvent>> GetSlideEvents()
        //{
        //    return await _HyperSloopService.GetSlideEventDataByEmail(Email);
        //}

    }
}
