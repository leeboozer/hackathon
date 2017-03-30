using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    public class VolunteerPoolCalcController : Controller
    {
        [HttpGet("{id}")]
        public IEnumerable<Object> Get(int id)
        {
            var volunteerPoolCalcRepository = new VolunteerPoolCalcRepository();
            var volPoolCalcs = volunteerPoolCalcRepository.GetVolunteerPoolCalcs(id, "name");

            var results =
                volPoolCalcs.Select(x =>
                    new
                    {
                        candidateId = x.CandidateId,
                        lastName = x.LastName,
                        firstName = x.FirstName,
                        status = x.Status
                    }).ToList();

            return results;
        }

    }
}
