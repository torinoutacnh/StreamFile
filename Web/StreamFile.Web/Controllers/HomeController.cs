using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace StreamFile.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(IServiceProvider serviceProvider)
        {
            _logger = Log.Logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
