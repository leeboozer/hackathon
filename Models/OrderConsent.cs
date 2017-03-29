using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderConsent
    {
        public long OrderConsentId { get; set; }
        public long? ClientId { get; set; }
        public long? ClientUserId { get; set; }
        public long? CandidateId { get; set; }
        public int ConsentTypeId { get; set; }
        public long NpnOrderId { get; set; }
        public DateTime DateOfConsent { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
