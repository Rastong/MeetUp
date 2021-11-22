using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMeetup.com.Models
{
    public class UserFavorites
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public ApplicationUser ApplicationUser { get; set; }

        public int CategoryID { get; set; }
        public int EventID { get; set; }

        [ForeignKey("EventID")]
        public EventList Event { get; set; }
        
    }
}
