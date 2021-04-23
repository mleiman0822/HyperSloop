using HyperSloopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data.Providers
{
    internal class UserProvider : IUserProvider
    {
        private readonly HyperSloopContext hyperSloopContext;

        public UserProvider(HyperSloopContext hyperSloopContext)
        {
            this.hyperSloopContext = hyperSloopContext;
        }
        public User Get(int KeyCardId)
        {
            return hyperSloopContext.Users.Where(u => u.KeyCardId == KeyCardId).FirstOrDefault();
        }

    }
}
