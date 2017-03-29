using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class StateAbuseCode
    {
        public long StateAbuseCodeId { get; set; }
        public string Code { get; set; }
        public int StateAbuseCodeTypeId { get; set; }
        public DateTime InsertDate { get; set; }
        public long? NpnOrderId { get; set; }
        public DateTime? DateAssigned { get; set; }
        public byte[] VersionStamp { get; set; }

        public virtual NpnOrder NpnOrder { get; set; }
    }
}
