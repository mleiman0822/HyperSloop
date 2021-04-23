using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Sensors
    {
        [Key]
        public int SensorId { get; set; }
        public int EventId { get; set; }
        public enum Slide 
        { orange = 1, 
          green = 2, 
          blue = 3
        }
        public DateTime Time { get; set; }
    }
}
