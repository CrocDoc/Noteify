using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Noteify.Models;

namespace Noteify.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<Config> _config;
        public HomeController(IOptions<Config> config)
        {
            this._config = config;
        }

        public IActionResult Index()
        {
            UserRepository repo = new UserRepository(_config);
            User user = repo.GetObjectByID(1);
            ViewData["Name"] = user.Username;
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
