using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Sensor
    {
        [Key]
        public int SensorId { get; set; }
        public string ExternalDeviceId { get; set; }
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
        public EventType EventType { get; set; }

        //Related Items 1 sensor to many SensorEvents 
        public ICollection<SensorEvent> SensorEvents { get; set; }

    }
}
