using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class StateSourceFee
    {
        public string StateName { get; set; }
        public string State { get; set; }
        public decimal SourceFee { get; set; }
    }
}
