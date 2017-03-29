using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NpnOrderProduct
    {
        public NpnOrderProduct()
        {
            OrderSearch = new HashSet<OrderSearch>();
            OrderUpdateSearch = new HashSet<OrderUpdateSearch>();
        }

        public long NpnOrderProductId { get; set; }
        public long NpnOrderId { get; set; }
        public long NpnProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? PartialTax { get; set; }
        public decimal Total { get; set; }
        public decimal UnitDiscount { get; set; }
        public decimal? Price { get; set; }
        public bool IsRemoved { get; set; }

        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual ICollection<OrderUpdateSearch> OrderUpdateSearch { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual NpnProduct NpnProduct { get; set; }
    }
}
