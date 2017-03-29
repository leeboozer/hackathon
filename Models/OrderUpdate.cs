using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderUpdate
    {
        public OrderUpdate()
        {
            JurisUpdate = new HashSet<JurisUpdate>();
            NationalCrimCaseHash = new HashSet<NationalCrimCaseHash>();
            OrderUpdateSearch = new HashSet<OrderUpdateSearch>();
        }

        public long OrderUpdateId { get; set; }
        public long NpnOrderId { get; set; }
        public int StatusId { get; set; }
        public int ResultId { get; set; }
        public long? SterlingId { get; set; }
        public DateTime DateMips { get; set; }
        public DateTime? DateAbsolveSubmit { get; set; }
        public DateTime? DateAbsolveComplete { get; set; }
        public int AbsolveOrderTypeId { get; set; }

        public virtual ICollection<JurisUpdate> JurisUpdate { get; set; }
        public virtual ICollection<NationalCrimCaseHash> NationalCrimCaseHash { get; set; }
        public virtual ICollection<OrderUpdateSearch> OrderUpdateSearch { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
