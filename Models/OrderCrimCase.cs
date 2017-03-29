using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderCrimCase
    {
        public OrderCrimCase()
        {
            OrderCrimCharge = new HashSet<OrderCrimCharge>();
        }

        public long NpnOrderId { get; set; }
        public long OrderCrimCaseId { get; set; }
        public bool Match { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string SourceId { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public long? OrderUpdateId { get; set; }

        public virtual ICollection<OrderCrimCharge> OrderCrimCharge { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
