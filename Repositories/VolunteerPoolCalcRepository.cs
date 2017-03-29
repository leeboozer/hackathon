using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace hackathon.Repositories
{
    public class VolunteerPoolCalcRepository
    {
        public VolunteerPoolCalcRepository()
        {
        }

        public List<VolunteerPoolCalc> GetVolunteerPoolCalcs(long ClientId, string SortBy = "name")
        {
            var query = Mercury.db.VolunteerPoolCalc.Where(x => x.ClientId == ClientId);

            switch (SortBy)
            {
                case "name":
                    query = query.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
                    break;
            }
            
            var data = query.ToList();

            return data;
        }
    }
}
