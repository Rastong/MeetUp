using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsMeetup.com.Models;
using EventsMeetup.com.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace EventsMeetup.com.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public ApplicationDbContext context;
        public EventsController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //returns List of all events for homepage
        //api/Events
        [HttpGet()]
        public List<EventList> GetAllEvents()
        {
            List<EventList> result = null;
            using (context)
            {
                result = context.eventLists.ToList();
            }
            return result;
        }


        //api/Events/{id}
        [HttpGet("{id}")]
        public EventList GetEventById(int id)
        {
            EventList result = null;
            using (context)
            {
                result = context.eventLists.Find(id);
            }
            return result;
        }

        //api/Events/AddEvent
        [HttpPost("AddEvent")]
        public EventList AddEvent(string name, string host, int categoryID, string summary, string photo, DateTime dateTime, int guestCount, bool spotsFilled )
        {
            EventList newEvent = new EventList()
            {
                Name = name,
                Host = host,
                CategoryID = categoryID,
                Summary = summary,
                Photo = photo,
                DateAndTime = dateTime,
                GuestCount = guestCount,
                SpotsFilled = spotsFilled
            };
            using (context) 
            {
                context.eventLists.Add(newEvent);
                context.SaveChanges();
            }

            return newEvent;
        }

    }
}

