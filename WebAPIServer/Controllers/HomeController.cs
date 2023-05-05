using Microsoft.AspNetCore.Mvc;
using WebAPIServer.Data;

namespace WebAPIServer.Controllers
{
    public class HomeController : Controller
    {
        CryptoDbContext db;
        public HomeController(CryptoDbContext db) 
        {
            this.db = db;
        
        }
        [HttpGet("/get")]
        public List<User> Index()
        {
            return db.Users.ToList();
        }
    }
}
