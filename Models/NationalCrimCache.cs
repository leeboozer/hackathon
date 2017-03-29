using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NationalCrimCache
    {
        public int NationalCrimCacheId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string ResponseXml { get; set; }
    }
}
