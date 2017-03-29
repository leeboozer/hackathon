using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class PositionNpnProduct
    {
        public long PositionProductId { get; set; }
        public long PositionId { get; set; }
        public long NpnProductId { get; set; }
        public string StateCode { get; set; }

        public virtual NpnProduct NpnProduct { get; set; }
        public virtual Position Position { get; set; }
    }
}
