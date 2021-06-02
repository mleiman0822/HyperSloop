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
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
        /// <summary>
        /// 0% percent is start of slide, 100% is end of the slide. 
        /// </summary>
        public double PercentageOfSlide { get; set; }

        //Related Items 1 sensor to many SensorEvents 
        public ICollection<SensorEvent> SensorEvents { get; set; }

    }
}
