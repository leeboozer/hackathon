using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SsnTraceRecordArchive
    {
        public long SsnTraceRecordArchiveId { get; set; }
        public long NpnOrderId { get; set; }
        public bool Match { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool? Valid { get; set; }
        public string IssueDates { get; set; }
        public string IssueState { get; set; }
        public bool? IsAlive { get; set; }
        public DateTime? FiledDate { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
