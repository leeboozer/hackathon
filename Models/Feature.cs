using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Feature
    {
        public Feature()
        {
            ClientFeature = new HashSet<ClientFeature>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }
        public byte AuthorizationRequirement { get; set; }
        public string AuthorizationLabel { get; set; }

        public virtual ICollection<ClientFeature> ClientFeature { get; set; }
    }
}
