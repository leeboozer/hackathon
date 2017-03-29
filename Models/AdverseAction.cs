using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class AdverseAction
    {
        public long AdverseActionId { get; set; }
        public long NpnOrderId { get; set; }
        public long ClientId { get; set; }
        public long CandidateId { get; set; }
        public long ClientUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; }
        public long? OrderUpdateId { get; set; }
        public long NpnProductId { get; set; }
        public string Reason { get; set; }
        public decimal Price { get; set; }
        public DateTime? ResumeDate { get; set; }
        public long OrderSharingId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual NpnProduct NpnProduct { get; set; }
        public virtual OrderSharing OrderSharing { get; set; }
    }
}
