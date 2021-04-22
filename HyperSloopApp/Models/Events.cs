using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        public DateTime EventTime { get; set; }
        public int KeyCardId { get; set; }
        public int SensorId { get; set; }

    }
}
