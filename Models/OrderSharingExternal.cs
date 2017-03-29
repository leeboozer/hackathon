using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderSharingExternal
    {
        public long OrderSharingExternalId { get; set; }
        public long CandidateId { get; set; }
        public long NpnOrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrgName { get; set; }
        public string ToAddress { get; set; }
        public string CcAddress { get; set; }
        public string CandidateComment { get; set; }
        public DateTime ShareConsentDate { get; set; }
        public bool EmailSent { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public DateTime? EmailFailDate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
