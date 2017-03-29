using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ApiLogError
    {
        public long ApiLogErrorId { get; set; }
        public long ClientId { get; set; }
        public string ErrorMessage { get; set; }
        public string ApiCandidateId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string Zip { get; set; }
        public DateTime LogTime { get; set; }
        public bool IsResolved { get; set; }

        public virtual Client Client { get; set; }
    }
}
