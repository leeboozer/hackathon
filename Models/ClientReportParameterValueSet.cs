using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientReportParameterValueSet
    {
        public long ClientReportParameterValueSetId { get; set; }
        public long ClientReportParameterId { get; set; }
        public short? Ordinal { get; set; }
        public string ValueName { get; set; }
        public string UserValueName { get; set; }

        public virtual ClientReportParameter ClientReportParameter { get; set; }
    }
}
