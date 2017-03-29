using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderSharing
    {
        public OrderSharing()
        {
            AdverseAction = new HashSet<AdverseAction>();
            CandidateCoupon = new HashSet<CandidateCoupon>();
            ClientCredit = new HashSet<ClientCredit>();
            VolunteerPool = new HashSet<VolunteerPool>();
        }

        public long OrderSharingId { get; set; }
        public long ClientId { get; set; }
        public long NpnOrderId { get; set; }
        public long CandidateId { get; set; }
        public byte Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsHidden { get; set; }
        public int? BadgeId { get; set; }
        public int EligibleStatusId { get; set; }
        public DateTime? EligibleDate { get; set; }
        public int ApiStatusId { get; set; }
        public DateTime? AdjudicationDate { get; set; }
        public int? CalculatedScore { get; set; }

        public virtual ICollection<AdverseAction> AdverseAction { get; set; }
        public virtual ICollection<CandidateCoupon> CandidateCoupon { get; set; }
        public virtual ICollection<ClientCredit> ClientCredit { get; set; }
        public virtual ICollection<VolunteerPool> VolunteerPool { get; set; }
        public virtual Badge Badge { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
