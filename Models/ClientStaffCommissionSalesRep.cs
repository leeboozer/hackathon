using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientStaffCommissionSalesRep
    {
        public long ClientStaffCommissionSalesRepId { get; set; }
        public long ClientStaffCommissionId { get; set; }
        public long SalesRepId { get; set; }
        public int Split { get; set; }

        public virtual ClientStaffCommission ClientStaffCommission { get; set; }
        public virtual Staff SalesRep { get; set; }
    }
}
