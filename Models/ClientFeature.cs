using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientFeature
    {
        public int ClientFeatureId { get; set; }
        public long ClientId { get; set; }
        public int FeatureId { get; set; }
        public string AuthorizationValue { get; set; }

        public virtual Client Client { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
