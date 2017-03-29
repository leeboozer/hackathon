using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class IdAuthenticationResultModification
    {
        public long IdAuthenticationResultModificationId { get; set; }
        public long IdAuthenticationResultId { get; set; }
        public int FieldEnum { get; set; }
        public int ModificationReasonEnum { get; set; }
        public string InitialValue { get; set; }
        public string ModifiedValue { get; set; }
        public DateTime ModificationDate { get; set; }
        public long? NpnOrderId { get; set; }

        public virtual IdAuthenticationResult IdAuthenticationResult { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
