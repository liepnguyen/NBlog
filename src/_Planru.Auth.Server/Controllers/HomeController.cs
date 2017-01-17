using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planru.Auth.Core.Persistence.EF;
using Planru.Auth.Core.Domain.Repositories;
using Planru.Auth.Core.Persistence.EF.Repositories;
using Planru.Auth.Core.Persistence.EF.Entities;

namespace Planru.Auth.Server.Controllers
{
    public class HomeController : Controller
    {
        private AuthDbContext _dbContext;
        private IUserRepository _userRepository;

        public IActionResult Index(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
            _userRepository = new UserRepository(dbContext);
            _userRepository.Add(new User() { });
            _dbContext.SaveChanges();
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
