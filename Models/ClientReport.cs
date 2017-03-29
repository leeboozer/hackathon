using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientReport
    {
        public ClientReport()
        {
            ClientReportAudit = new HashSet<ClientReportAudit>();
            ClientReportParameter = new HashSet<ClientReportParameter>();
        }

        public int ClientReportId { get; set; }
        public short? DisplayPriority { get; set; }
        public string ReportName { get; set; }
        public string ReportCodeName { get; set; }
        public string Description { get; set; }
        public string Parameters { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ClientReportAudit> ClientReportAudit { get; set; }
        public virtual ICollection<ClientReportParameter> ClientReportParameter { get; set; }
    }
}
