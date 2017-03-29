using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NationalCrimCaseHash
    {
        public long NationalCrimCaseHashId { get; set; }
        public long NpnOrderId { get; set; }
        public long? OrderUpdateId { get; set; }
        public string HashValue { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsDiff { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string CourtName { get; set; }
        public string CaseNumbers { get; set; }
        public bool NewCase { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
        public virtual OrderUpdate OrderUpdate { get; set; }
    }
}
