using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class ScanEvent
    {
        [Key]
        public int ScanEventId { get; set; }  
        public User User { get; set; }
        public Slide Slide { get; set; }
        public DateTime StartTime { get; set; }
    }
}
