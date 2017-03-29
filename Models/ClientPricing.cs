using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientPricing
    {
        public int ClientPricingId { get; set; }
        public long ClientId { get; set; }
        public long NpnProductId { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public decimal PassBackAmount { get; set; }
        public string EnteredBy { get; set; }

        public virtual Client Client { get; set; }
        public virtual NpnProduct NpnProduct { get; set; }
    }
}
