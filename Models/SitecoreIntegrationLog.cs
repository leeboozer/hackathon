using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class SitecoreIntegrationLog
    {
        public long Id { get; set; }
        public DateTime? DateRequest { get; set; }
        public int? PageRequest { get; set; }
        public string Result { get; set; }
        public DateTime? Date { get; set; }
    }
}
