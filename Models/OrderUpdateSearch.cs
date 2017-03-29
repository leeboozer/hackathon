using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderUpdateSearch
    {
        public long OrderUpdateSearchId { get; set; }
        public long OrderUpdateId { get; set; }
        public int? SterlingWestProductCode { get; set; }
        public decimal Price { get; set; }
        public long NpnOrderProductId { get; set; }
        public int? JurisUpdateId { get; set; }
        public long? InstantId { get; set; }
        public int? Score { get; set; }
        public int? SearchReqId { get; set; }

        public virtual JurisUpdate JurisUpdate { get; set; }
        public virtual NpnOrderProduct NpnOrderProduct { get; set; }
        public virtual OrderUpdate OrderUpdate { get; set; }
    }
}
