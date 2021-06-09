using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperSloopApp.Models
{
    public class SlideEvent 
    {
        [Key]
        public string SlideEventId { get; set; }        
        public int UserId { get; set; }
        public User User { get; set; }
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
        public DateTime ScanTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Column("Scan Duration")]
        public double ScanDuration {get; set; }
        [Column("Slide Duration")]
        public double SlideDuration { get; set; }
        [NotMapped]
        public double? AverageSpeed => Slide?.LengthInFeet / SlideDuration;
        [NotMapped]
        public double? VertcialSpeed => Slide?.HeightInFeet / SlideDuration;

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
