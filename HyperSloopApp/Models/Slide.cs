using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Slide
    {

        public int SlideId { get; set; }
        public string Color { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }
        public int StartFloor { get; set; }
        public int EndFloor { get; set; }
        public Sensors Sensors { get; set; }
    }
}
