using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FinalOpgaveDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        ICustomerService service;
        public HomeController(ICustomerService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            Random random = new Random();
            int r = random.Next(1, 5);
            ViewData["number"] = r;
            ViewData["bike"] = "/images/bikes/bike" + r + ".jpg";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}