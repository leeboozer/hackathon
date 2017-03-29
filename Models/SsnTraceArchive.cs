using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SsnTraceArchive
    {
        public long SsnTraceArchiveId { get; set; }
        public long NpnOrderId { get; set; }
        public string SsnTraceData { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
