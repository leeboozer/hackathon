using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisUpdate
    {
        public JurisUpdate()
        {
            OrderUpdateSearch = new HashSet<OrderUpdateSearch>();
        }

        public int JurisUpdateId { get; set; }
        public int JurisId { get; set; }
        public decimal Price { get; set; }
        public byte JurisType { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }
        public int SourceTypeId { get; set; }
        public long OrderUpdateId { get; set; }

        public virtual ICollection<OrderUpdateSearch> OrderUpdateSearch { get; set; }
        public virtual Jurisdiction Juris { get; set; }
        public virtual OrderUpdate OrderUpdate { get; set; }
        public virtual SourceType SourceType { get; set; }
    }
}
