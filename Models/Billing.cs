using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Billing
    {
        public long BillingId { get; set; }
        public long ClientId { get; set; }
        public string BillingAttn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailId { get; set; }
        public string Type { get; set; }
        public string Frequency { get; set; }
        public string SolomonBillingId { get; set; }
        public decimal? SetupFee { get; set; }
        public bool Billed { get; set; }
        public bool TaxExempt { get; set; }
        public string TaxExemptId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int BillingCodeOrigin { get; set; }

        public virtual Client Client { get; set; }
    }
}
