using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Sensors
    {
        public int SensorId { get; set; }
        public int SlideId { get; set; }
        public string SensorType { get; set; }
        public string Region { get; set; }

        public ICollection<Slide> Slides { get; set; }
    }
}
