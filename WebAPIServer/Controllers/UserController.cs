using Microsoft.AspNetCore.Mvc;
using WebAPIServer.Data;

namespace WebAPIServer.Controllers
{
    public class UserController : Controller
    {
        CryptoDbContext db;
        public UserController(CryptoDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/user")]
        public User Index()
        {
            return db.Users.ToList()[0];
        }
    }
}
