using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class AddressInformation
    {
        public long AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long NpnOrderId { get; set; }
        public long CandidateId { get; set; }
        public string Country { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
