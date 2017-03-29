using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientCredit
    {
        public long ClientCreditId { get; set; }
        public DateTime DateCreated { get; set; }
        public long NpnOrderId { get; set; }
        public long ClientId { get; set; }
        public decimal Amount { get; set; }
        public long OrderSharingId { get; set; }

        public virtual Client Client { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
        public virtual OrderSharing OrderSharing { get; set; }
    }
}
