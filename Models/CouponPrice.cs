using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CouponPrice
    {
        public long CouponPriceId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
