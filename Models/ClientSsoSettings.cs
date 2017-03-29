using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientSsoSettings
    {
        public long ClientSsosettingsId { get; set; }
        public long ClientId { get; set; }
        public string PemString { get; set; }
        public string ApiCandidateIdJsonPath { get; set; }
        public string ClientBaseAddress { get; set; }
        public string ClientCertApi { get; set; }

        public virtual Client Client { get; set; }
    }
}
