using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ProductAudit
    {
        public long ProductAuditId { get; set; }
        public long NpnProductId { get; set; }
        public int Counter { get; set; }
        public int AuditOrder { get; set; }
        public int Matches { get; set; }

        public virtual NpnProduct NpnProduct { get; set; }
    }
}
