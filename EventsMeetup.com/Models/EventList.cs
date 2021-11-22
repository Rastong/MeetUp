using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMeetup.com.Models
{
    public class EventList
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Host { get; set; }
        public int CategoryID { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Summary { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Photo { get; set; }
        public DateTime DateAndTime { get; set; }
        public int GuestCount { get; set; }
        public bool SpotsFilled { get; set; }
        
    }
}
