using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientProductAuthorization
    {
        public long ClientProductAuthorizationId { get; set; }
        public long ProductAuthorizationId { get; set; }
        public byte Enabled { get; set; }
        public string ActivationKey { get; set; }
        public string Notes { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public long ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ProductAuthorization ProductAuthorization { get; set; }
    }
}
