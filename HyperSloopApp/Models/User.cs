using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{

    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Events> Events { get; set; }
        

        //[Key]
        //public int UserId { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public int ScanEventId { get; set; }
        //public ICollection<ScanEvent> ScanEvents { get; set; }
        //public ICollection<SlideEvent> SlideEvents { get; set; }
 

    }
}
