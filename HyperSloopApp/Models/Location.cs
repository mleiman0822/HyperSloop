using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class Location
    { 
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public ICollection<Slide> Slides { get; set; }

        //Expandable information

    }
}
