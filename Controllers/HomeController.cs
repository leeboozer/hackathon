using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Models;
using hackathon.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var volunteerPoolCalcs = Mercury.db.VolunteerPoolCalc.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            var clients = new ClientRepository().GetClients();
            var volPoolCalcs = new VolunteerPoolCalcRepository().GetVolunteerPoolCalcs(clients[0].ClientId);
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
