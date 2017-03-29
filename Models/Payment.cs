using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Payment
    {
        public Payment()
        {
            NpnOrder = new HashSet<NpnOrder>();
            SharingSubscription = new HashSet<SharingSubscription>();
        }

        public long PaymentId { get; set; }
        public string SolomonBillingId { get; set; }
        public string TransId { get; set; }
        public string AppCode { get; set; }
        public string Name { get; set; }
        public string PaymentType { get; set; }
        public string Ccnum { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Cctype { get; set; }
        public string CardBrandSelected { get; set; }
        public string Cvvmatch { get; set; }
        public string Avsmatch { get; set; }
        public string ApprovalCode { get; set; }
        public string TransactionStart { get; set; }
        public string TransactionEnd { get; set; }
        public string HostedSecureId { get; set; }
        public string SessionId { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string Rurl { get; set; }
        public DateTime Added { get; set; }
        public string RawInput { get; set; }
        public int? StatusId { get; set; }

        public virtual ICollection<NpnOrder> NpnOrder { get; set; }
        public virtual ICollection<SharingSubscription> SharingSubscription { get; set; }
    }
}
