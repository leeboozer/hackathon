using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SeedData
    {
        public int SeedDataId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public int? Mvrlicense { get; set; }
        public int? PhoneExt { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public int? Ssn { get; set; }
        public int? Id { get; set; }
    }
}
