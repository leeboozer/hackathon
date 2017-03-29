using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisOrder
    {
        public JurisOrder()
        {
            OrderSearch = new HashSet<OrderSearch>();
        }

        public int JurisOrderId { get; set; }
        public int JurisId { get; set; }
        public long NpnOrderId { get; set; }
        public decimal Price { get; set; }
        public byte JurisType { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }
        public int SourceTypeId { get; set; }
        public long SterlingWestProductId { get; set; }
        public bool RegulatedJuris { get; set; }

        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual Jurisdiction Juris { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual SourceType SourceType { get; set; }
    }
}
