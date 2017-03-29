using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Models;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var volunteerPoolCalcs = Mercury.db.VolunteerPoolCalc.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
