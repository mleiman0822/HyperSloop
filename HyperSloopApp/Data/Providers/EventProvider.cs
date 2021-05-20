using HyperSloopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data.Providers
{
    internal class EventProvider : IEventProvider
    {
        private readonly HyperSloopContext hyperSloopContext;

        public EventProvider(HyperSloopContext hyperSloopContext)
        {
            this.hyperSloopContext = hyperSloopContext;
        }
        public Events Get(int EventId)
        {
            return hyperSloopContext.Events.Where(e => e.EventId == EventId).FirstOrDefault();
        }

    }
}
