using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        public DateTime DateTime { get; set; }
        public EventType EventType { get; set; }
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        //public int SensorId { get; set; }
        //public Sensor Sensor { get; set; }
    }

    public enum EventType
    {
        UserStart = 1,
        SlideStart = 2,
        SlideEnd = 3
    }

//    SELECT CONCAT(userstart.eventid, '_', slidestart.eventid, "_", slideend.eventid) as 'SlideEventid',
//userstart.userid as 'UserId',
//userstart.slideid as 'SlideId',
//userstart.datetime as 'ScanTime',
//slidestart.datetime as 'StartTime',
//slideend.datetime as 'EndTime',
//TIMESTAMPDIFF(MICROSECOND, userstart.DateTime, slidestart.DateTime) / 1000000 as 'Scan Duration',
//TIMESTAMPDIFF(MICROSECOND, slidestart.DateTime, slideend.DateTime) / 1000000 as 'Slide Duration' 
//FROM hypersloop.events as userstart
//JOIN hypersloop.events as slidestart on
//    userstart.SlideId = slidestart.SlideId
//    AND slidestart.DateTime > userstart.DateTime
//    AND TIMESTAMPDIFF(SECOND, userstart.DateTime, slidestart.DateTime) < 10
//    AND slidestart.EventType = 2 AND userstart.EventType = 1
//JOIN hypersloop.events as slideend
//    on slidestart.SlideId = slideend.SlideId
//    AND slideend.DateTime > slidestart.DateTime
//    AND TIMESTAMPDIFF(SECOND, slidestart.DateTime, slideend.DateTime) < 10
//    AND slideend.EventType = 3
}
