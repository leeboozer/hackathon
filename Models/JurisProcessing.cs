using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class JurisProcessing
    {
        public string State { get; set; }
        public bool IsPreferredStatewide { get; set; }
        public bool IsProhibitedStatewide { get; set; }
        public bool IsProhibitedCounty { get; set; }
        public bool RegulatedJuris { get; set; }
    }
}
