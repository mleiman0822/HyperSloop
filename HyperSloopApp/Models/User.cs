using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Models
{
    public class User
    {
        [Key]
        public int KeyCardId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public string OauthToken { get; set; }
        public ICollection<Events> Events { get; set; }
    }
}
