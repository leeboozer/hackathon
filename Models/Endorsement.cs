using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Endorsement
    {
        public int EndorsementId { get; set; }
        public string EndorsementName { get; set; }
        public bool IsActive { get; set; }
        public string FileName { get; set; }
        public long NpnProductId { get; set; }

        public virtual NpnProduct NpnProduct { get; set; }
    }
}
