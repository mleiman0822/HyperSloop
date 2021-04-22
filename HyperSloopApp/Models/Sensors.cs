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
        public int SlideId { get; set; }
        public string SensorType { get; set; }
        public string Region { get; set; }

        public ICollection<Slide> Slides { get; set; }
    }
}
