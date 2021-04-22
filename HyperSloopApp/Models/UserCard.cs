using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class UserCard
    {
        [Key]
        public int KeyCardId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }

        //Navigation property that creates a one to many relationship. User has 1 or more events.
        public ICollection<Events> Events { get; set; }
    }
}
