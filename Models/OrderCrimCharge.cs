using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderCrimCharge
    {
        public long NpnOrderId { get; set; }
        public long OrderCrimCaseId { get; set; }
        public long OrderCrimChargeId { get; set; }
        public string CaseNumber { get; set; }
        public string StatuteNumber { get; set; }
        public string Charge { get; set; }
        public string ChargeType { get; set; }
        public string CourtName { get; set; }
        public string CaseType { get; set; }
        public string Disposition { get; set; }
        public DateTime? DispositionDate { get; set; }
        public string OffenseCounty { get; set; }
        public DateTime? OffenseDate { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
        public virtual OrderCrimCase OrderCrimCase { get; set; }
    }
}
