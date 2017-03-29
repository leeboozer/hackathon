    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Models;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Object> GetAll()
        {
            var clients = 
                Mercury.db.Client
                    .OrderBy(x => x.AccountName)
                    .Select(x => new { clientId = x.ClientId, accountName = x.AccountName})
                    .ToList();

            return clients;
        }

    }
}
