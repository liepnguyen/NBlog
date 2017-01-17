using Microsoft.AspNetCore.Mvc;
using Planru.Auth.Core.Persistence;

namespace Planru.Auth.Server.Controllers
{
    public class HomeController : Controller
    {
        private AuthDbContext _dbContext;

        public HomeController(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
