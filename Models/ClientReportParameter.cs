using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientReportParameter
    {
        public ClientReportParameter()
        {
            ClientReportParameterValueSet = new HashSet<ClientReportParameterValueSet>();
        }

        public long ClientReportParameterId { get; set; }
        public int? ClientReportId { get; set; }
        public short? Ordinal { get; set; }
        public string ParameterName { get; set; }
        public string UserParameterName { get; set; }
        public string ValidValues { get; set; }
        public string UicontrolType { get; set; }

        public virtual ICollection<ClientReportParameterValueSet> ClientReportParameterValueSet { get; set; }
        public virtual ClientReport ClientReport { get; set; }
    }
}
