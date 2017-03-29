using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Alias
    {
        public Alias()
        {
            OrderSearch = new HashSet<OrderSearch>();
        }

        public long AliasId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool AddedByUser { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? CandidateId { get; set; }
        public long? NpnOrderId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<OrderSearch> OrderSearch { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
