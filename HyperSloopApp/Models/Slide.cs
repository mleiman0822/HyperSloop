using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Slide
    {
        [Key]

        public int SlideId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public string HexColor { get; set; }
        public double LengthInFeet { get; set; }
        public double HeightInFeet { get; set; }
        public int StartingFloor { get; set; }
        public int EndingFloor { get; set; }

        //public int SlideId { get; set; }
        //public string HexColor { get; set; }
        //public double LengthInFeet { get; set; }
        //public double HeightInFeet { get; set; }
        //public int StartingFloor { get; set; }
        //public int EndingFloor { get; set; }
        //public int LocationId { get; set; }
        //public Location Location { get; set; }
        //public ICollection<Sensor> Sensors { get; set; }
        //public ICollection<SlideEvent> SlideEvents { get; set; }
    }
}
