using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateCoupon
    {
        public CandidateCoupon()
        {
            CandidateCouponUsage = new HashSet<CandidateCouponUsage>();
        }

        public long CandidateCouponId { get; set; }
        public DateTime DateCreated { get; set; }
        public long NpnOrderId { get; set; }
        public long CandidateId { get; set; }
        public decimal Amount { get; set; }
        public long OrderSharingId { get; set; }
        public int Status { get; set; }
        public int Reminder { get; set; }

        public virtual ICollection<CandidateCouponUsage> CandidateCouponUsage { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual OrderSharing OrderSharing { get; set; }
    }
}
