using System.ComponentModel.DataAnnotations;

namespace HyperSloopApp.Models
{
    public class SlideEvent
    {
        [Key]
        public int SlideEventId { get; set; }
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ScanEventId { get; set; }
        public ScanEvent ScanEvent { get; set; }
        public int StartingSensorEventId { get; set; }
        public SensorEvent StartingSensorEvent { get; set; }
        public int EndingSensorEventId { get; set; }
        public SensorEvent EndingSensorEvent { get; set; }

    }
}
