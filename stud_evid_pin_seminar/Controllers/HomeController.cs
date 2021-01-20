using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stud_evid_pin_seminar.Data;
using stud_evid_pin_seminar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace stud_evid_pin_seminar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentContext _context;
        public HomeController(ILogger<HomeController> logger, StudentContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (_context)
            {
                List<Student> x = _context.Student.ToList();
                ViewBag.ListLength = x.Count;
                ViewBag.Studenti = x;
            }
            return View();
        }

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
