using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateCouponUsage
    {
        public long CandidateBalanceId { get; set; }
        public long? NpnOrderId { get; set; }
        public long? CandidateCouponId { get; set; }
        public decimal? Amount { get; set; }
        public int UsageType { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual CandidateCoupon CandidateCoupon { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
