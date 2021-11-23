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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserFavoritesController : ControllerBase
    {
        public ApplicationDbContext context;
        public UserFavoritesController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //api/UserFavorites/GetFavorites
        [HttpGet("GetFavorites")]
        public List<UserFavorites> GetFavorites()
        { 
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            return this.context.userFavorites.Where(F => F.UserID == currentUserID).ToList();
        }

        //api/UserFavorites/AddFavorite
        [HttpPost("AddFavorite")]
        public UserFavorites AddFavorite(int eventId, int categoryID)
        {
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            UserFavorites result = new UserFavorites() { EventID = eventId, UserID = currentUserID, CategoryID = categoryID };
            this.context.userFavorites.Add(result);
            this.context.SaveChanges();

            return result;
        }

        //api/UserFavorites/DeleteFavorite/{id}
        [HttpDelete("DeleteFavorite/{id}")]
        public UserFavorites DeleteFavorite(int id)
        {
            ClaimsPrincipal currentUser = this.User;
            string currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            UserFavorites result = this.context.userFavorites.ToList().Find(e => e.EventID ==id && e.UserID == currentUserID);
            this.context.userFavorites.Remove(result);
            this.context.SaveChanges();

            return result;
        }
    }
}
