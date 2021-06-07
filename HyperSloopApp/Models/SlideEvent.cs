using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperSloopApp.Models
{
    public class SlideEvent
    {

        [Key]
        public int SlideEventId { get; set; }
        
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public int SlideId { get; set; }
        public DateTime StartTime { get; set; }
        public double Duration { get; set; }
        [NotMapped]
        public double AverageSpeed { get; set; }
        [NotMapped]
        public double VertcialSpeed { get; set; }

        //[Key]
        //public int SlideEventId { get; set; }
        //public int SlideId { get; set; }
        //public Slide Slide { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        //public int ScanEventId { get; set; }
        //public ScanEvent ScanEvent { get; set; }
        //[ForeignKey()]
        //public int StartingSensorEventId { get; set; }
        //public SensorEvent StartingSensorEvent { get; set; }
        //public int EndingSensorEventId { get; set; }
        //public SensorEvent EndingSensorEvent { get; set; }
       
    }
}
