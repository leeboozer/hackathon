using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NationalCrimArchive
    {
        public long NationCrimArchiveId { get; set; }
        public long NpnOrderId { get; set; }
        public string NationalCrimData { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
