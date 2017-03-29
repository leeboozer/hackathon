using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CountySourceFee
    {
        public string State { get; set; }
        public string County { get; set; }
        public decimal SourceFee { get; set; }
    }
}
