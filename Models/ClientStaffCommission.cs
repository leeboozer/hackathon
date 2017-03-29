using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientStaffCommission
    {
        public ClientStaffCommission()
        {
            ClientStaffCommissionSalesRep = new HashSet<ClientStaffCommissionSalesRep>();
        }

        public long ClientId { get; set; }
        public long? PrimaryAm { get; set; }
        public long? SecondaryAm { get; set; }
        public long PrimaryCse { get; set; }
        public long? SecondaryCse { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string TimeZone { get; set; }
        public bool CommissionAppPartner { get; set; }
        public long? Reseller { get; set; }
        public bool CommissionAppReseller { get; set; }
        public long ClientStaffCommissionId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? SalesQuota { get; set; }
        public long? PartnerId { get; set; }

        public virtual ICollection<ClientStaffCommissionSalesRep> ClientStaffCommissionSalesRep { get; set; }
        public virtual Client Client { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
