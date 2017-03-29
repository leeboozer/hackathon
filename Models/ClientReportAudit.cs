using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientReportAudit
    {
        public long ClientReportAuditId { get; set; }
        public long ClientId { get; set; }
        public long ClientUserId { get; set; }
        public int ClientReportId { get; set; }
        public DateTime RunDate { get; set; }
        public string DateRangeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Url { get; set; }
        public string ParametersJson { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientReport ClientReport { get; set; }
        public virtual ClientUser ClientUser { get; set; }
    }
}
