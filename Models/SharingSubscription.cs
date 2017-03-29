using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SharingSubscription
    {
        public long SharingSubscriptionId { get; set; }
        public long NpnOrderId { get; set; }
        public long NpnProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? PartialTax { get; set; }
        public decimal Total { get; set; }
        public decimal UnitDiscount { get; set; }
        public decimal? Price { get; set; }
        public long? PaymentId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
