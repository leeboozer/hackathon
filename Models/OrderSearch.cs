using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderSearch
    {
        public long OrderSearchId { get; set; }
        public long NpnOrderId { get; set; }
        public int? SterlingWestProductCode { get; set; }
        public decimal Price { get; set; }
        public long? AliasId { get; set; }
        public long NpnOrderProductId { get; set; }
        public int? JurisOrderId { get; set; }
        public long? InstantId { get; set; }
        public int? Score { get; set; }
        public int? SearchReqId { get; set; }
        public long NpnProductId { get; set; }
        public long? OrderReferenceId { get; set; }

        public virtual Alias Alias { get; set; }
        public virtual JurisOrder JurisOrder { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual NpnOrderProduct NpnOrderProduct { get; set; }
        public virtual NpnProduct NpnProduct { get; set; }
        public virtual OrderReference OrderReference { get; set; }
    }
}
