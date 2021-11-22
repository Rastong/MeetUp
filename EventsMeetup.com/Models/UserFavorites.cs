using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMeetup.com.Models
{
    public class UserFavorites
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }

        public int CategoryID { get; set; }
        public int EventID { get; set; }
    }
}
