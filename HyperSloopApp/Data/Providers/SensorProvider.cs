using HyperSloopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data.Providers
{
    internal class SensorProvider : ISensorProvider
    {
        private readonly HyperSloopContext hyperSloopContext;

        public SensorProvider(HyperSloopContext hyperSloopContext)
        {
            this.hyperSloopContext = hyperSloopContext;
        }
        public Sensors Get(int SensorId)
        {
            return hyperSloopContext.Sensors.Where(s => s.SensorId == SensorId).FirstOrDefault();
        }

    }
}
}
