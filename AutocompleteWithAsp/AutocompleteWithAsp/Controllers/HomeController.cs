using AutocompleteWithAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutocompleteWithAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FakeContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _context = new FakeContext();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AJaxForNames(string name) =>
            Json(_context.Names.Where(x => x.ToLower().Contains(name.ToLower())).Take(5).ToList());
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
