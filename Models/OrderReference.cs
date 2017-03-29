using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderReference
    {
        public OrderReference()
        {
            OrderSearch = new HashSet<OrderSearch>();
        }

        public long OrderReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Relationship { get; set; }
        public long CandidateId { get; set; }
        public long NpnOrderId { get; set; }
        public string KnownAsFirstName { get; set; }
        public string KnownAsMiddleName { get; set; }
        public string KnownAsLastName { get; set; }

        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
