using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class SensorEvent
    {
        [Key]
        public int SensorEventId { get; set; }
        public int SensorId { get; set; }
        public Sensor Sensor { get; set; }
        public DateTime Time { get; set; }
    }
}
